namespace MapPortingUtility {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Windows.Forms;
    using System.Diagnostics;

    public class T5xportHelper : ExportHelper {
        private const string EXECUTABLE_NAME = "t5x-port.exe";

        [System.Serializable]
        struct MaterialStub {
            public byte[] stateBitsEntry;
        }

        [System.Serializable]
        struct TechniqueSetStub {
            public Dictionary<string, string> techniques;
        }

        public static Map[] GetMapList(ref Paths paths)
        {
            List<Map> maps = new List<Map>();
            string basePath = paths.T5Path;

            for (int i = 0; i < CANONICAL_LANGUAGES.Length; i++) {
                var lang = CANONICAL_LANGUAGES[i];
                try {
                    var directory = Path.Combine(basePath, string.Format(CANONICAL_MAP_DIRECTORY_FMT, lang));

                    if (Directory.Exists(directory)) {
                        var files = Directory.GetFiles(directory);

                        foreach (var file in files) {
                            if (!file.EndsWith(MAP_EXT_FILTER))
                                continue;
                            if (!Path.GetFileName(file).StartsWith(MAP_PREFIX_FILTER))
                                continue;
                            if (file.EndsWith(MAP_SUFFIX_FILTER + MAP_EXT_FILTER))
                                continue;

                            maps.Add(new Map() {
                                Path = Path.Combine(file),
                                Category = Map.ECategory.CANONICAL
                            });
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Could not list canonical maps for t5 for language {lang}!\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (Directory.Exists(Path.Combine(basePath, USERMAPS_MAP_DIRECTORY))) {
                try {
                    var directories = Directory.GetDirectories(Path.Combine(basePath, USERMAPS_MAP_DIRECTORY));

                    foreach (var directory in directories) {
                        var files = Directory.GetFiles(directory);
                        foreach (var file in files) {
                            if (!file.EndsWith(MAP_EXT_FILTER)) continue;
                            if (!Path.GetFileName(file).StartsWith(MAP_PREFIX_FILTER)) continue;
                            if (file.EndsWith(MAP_SUFFIX_FILTER + MAP_EXT_FILTER)) continue;

                            maps.Add(new Map() {
                                Path = Path.Combine(file),
                                Category = Map.ECategory.USERMAPS
                            });
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Could not list user maps for t5!\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return maps.ToArray();
        }

        public static int DumpMap(Map map, ref Paths paths, Action<string> pipe)
        {
            string exePath = Path.Combine(paths.T5Path, EXECUTABLE_NAME);

            if (!File.Exists(exePath)) {
                pipe.Invoke($"Missing {exePath}!");
                return -1;
            }

            var proc = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = exePath,
                    WorkingDirectory = paths.T5Path,
                    Arguments = $"-multiplayer -exporter +set export_path {GetDumpDestinationPath(ref map, ref paths)} +dumpmap {map.Name} +quit",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    RedirectStandardError = true
                }
            };

            pipe($"{exePath} {proc.StartInfo.Arguments}");
            proc.OutputDataReceived += (sender, args) =>
            {
                pipe(args.Data);
            };
            proc.ErrorDataReceived += (sender, args) =>
            {
                pipe(args.Data);
            };

            proc.Start();
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();
            proc.WaitForExit();

            return proc.ExitCode;
        }


        public static bool RegenerateMaterials(Map map, ref Paths paths, Action<string> pipe)
        {
            string outputPath = GetDumpDestinationPath(ref map, ref paths);

            pipe("Copying support files over...");
            string supportAssets = Path.Combine("static", "t5_support_assets");
            if (Directory.Exists(supportAssets)) {
                CopyDirectory(supportAssets, outputPath);
            }

            pipe("Regenerating materials...");
            string overridesPath = Path.Combine(outputPath, "_t5xport_techset_overrides");

            var deserializer = new YamlDotNet.Serialization.DeserializerBuilder()
                .IgnoreUnmatchedProperties()
                .Build();


            const string EXT = ".iw4_techset";
            var overrides = Directory.GetFiles(overridesPath, $"*{EXT}", SearchOption.AllDirectories);
            bool broken = false;
            foreach (var overridesFile in overrides) {
                string materialName = overridesFile.Substring(overridesPath.Length + 1);
                materialName = materialName.Substring(0, materialName.Length - EXT.Length);
                string materialsPath = Path.Combine(outputPath, "materials", $"{materialName}.iw4x.json");
                if (File.Exists(materialsPath)) {
                    string tsName = File.ReadAllText(overridesFile).Trim();
                    string tsPath = Path.Combine(outputPath, "techsets", $"{tsName}.iw4x.json");

                    if (File.Exists(tsPath)) {
                        // All good

                        var material = deserializer.Deserialize<MaterialStub>(System.IO.File.ReadAllText(materialsPath));
                        var techniqueSet = deserializer.Deserialize<TechniqueSetStub>(System.IO.File.ReadAllText(tsPath));


                        for (int i = 0; i < material.stateBitsEntry.Length; i++) {
                            if (i < 0x4) { // BUILD_
                                continue;
                            }

                            if (i > 0x25) { // LIT END
                                continue;
                            }

                            if (material.stateBitsEntry[i] != byte.MaxValue && techniqueSet.techniques[i.ToString()] == null) {
                                pipe($"Discredepency between expected techniqueset {tsName}'s slots and material {materialName}: expected something in slot {i}");
                                broken = true;
                            }
                        }
                    }
                    else {
                        Directory.CreateDirectory(Path.Combine(outputPath, "techsets"));
                        string missTxtPath = Path.Combine(outputPath, "techsets", "missing_techsets.txt");

                        if (!File.Exists(missTxtPath)) {
                            File.WriteAllText(missTxtPath, "-zonebuilder +loadzone mp_highrise +loadzone mp_underpass +loadzone mp_afghan +loadzone mp_derail");
                        }

                        string existing = File.ReadAllText(missTxtPath);
                        if (!existing.Contains(tsName)) {
                            File.AppendAllText(missTxtPath, $" +dumptechset {tsName}");
                            if (tsName.Contains("_l_sm")) {
                                File.AppendAllText(missTxtPath, $" +dumptechset {tsName.Replace("_sm", "_hsm")}");
                            }
                        }
                    }
                }
            }

            return !broken;
        }

        private static void CopyDirectory(string sourceDir, string destinationDir)
        {
            // Get information about the source directory
            var originDir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!originDir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {originDir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = originDir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in originDir.GetFiles()) {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath, overwrite: true);
            }

            foreach (DirectoryInfo subDir in dirs) {
                string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                CopyDirectory(subDir.FullName, newDestinationDir);
            }
        }
    }
}
