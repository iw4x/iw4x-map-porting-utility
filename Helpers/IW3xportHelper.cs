namespace MapPortingUtility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Windows.Forms;
    using System.Diagnostics;

    public static class IW3xportHelper
    {
        public struct Map
        {
            public enum ECategory
            {
                CANONICAL,
                USERMAPS
            }
            public string Name => System.IO.Path.GetFileNameWithoutExtension(Path);

            public ECategory Category;
            public string Path;

            public override string ToString() => Name;
        }

        private const string MAP_PREFIX_FILTER = "mp_";
        private const string MAP_SUFFIX_FILTER = "_load";
        private const string MAP_EXT_FILTER = ".ff";
        private const string EXECUTABLE_NAME = "iw3xport.exe";

        private static readonly string CANONICAL_MAP_DIRECTORY = Path.Combine("zone", "english");
        private static readonly string USERMAPS_MAP_DIRECTORY = Path.Combine("usermaps");

        public static Map[] GetMapList(ref Paths paths)
        {
            List<Map> maps = new List<Map>();
            string basePath = paths.IW3Path;

            try {
                var files = Directory.GetFiles(Path.Combine(basePath, CANONICAL_MAP_DIRECTORY));

                foreach (var file in files) {
                    if (!file.EndsWith(MAP_EXT_FILTER)) continue;
                    if (!Path.GetFileName(file).StartsWith(MAP_PREFIX_FILTER)) continue;
                    if (file.EndsWith(MAP_SUFFIX_FILTER + MAP_EXT_FILTER)) continue;

                    maps.Add(new Map() {
                        Path = Path.Combine(file),
                        Category = Map.ECategory.CANONICAL
                    });
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Could not list canonical maps for iw3!\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show($"Could not list user maps for iw3!\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return maps.ToArray();
        }

        public static int DumpMap(Map map, ref Paths paths, bool correctSpeculars, bool convertGSCs, uint correctSmodelsMethod, Action<string> pipe)
        {
            string exePath = Path.Combine(paths.IW3Path, EXECUTABLE_NAME);

            if (!File.Exists(exePath)) {
                pipe.Invoke($"Missing {exePath}!");
                return -1;
            }

            var proc = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = exePath,
                    WorkingDirectory = paths.IW3Path,
                    Arguments = $"-stdout +set iw3x_correct_speculars {(correctSpeculars ? 1 : 0)} +set iw3x_convert_gsc {(correctSpeculars ? 1 : 0)} +set iw3x_smodels_fix_method {correctSmodelsMethod} +set export_path {GetDumpDestinationPath(ref map, ref paths)} +dumpmap {map.Name} +quit",
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


        public static string GetDumpDestinationPath(ref Map map, ref Paths paths) => GetDumpDestinationPath(map.Name, ref paths);
        public static string GetDumpDestinationPath(string mapName, ref Paths paths) => Path.Combine(paths.IW4Path, "mods", mapName);
    }
}
