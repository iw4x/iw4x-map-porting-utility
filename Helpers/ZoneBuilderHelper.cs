namespace MapPortingUtility
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ZoneBuilderHelper
    {
        const string ZONE_SOURCE_FOLDER = "zone_source";
        const string MAP_DESTINATION_FOLDER = "usermaps";
        const string EXECUTABLE_NAME = "iw4x.exe";

        static readonly string teamSourceFolder = Path.Combine("static", "team_source");

        public static string GetSourceFolderPath(ref Paths paths) => Path.Combine(paths.IW4Path, ZONE_SOURCE_FOLDER);

        public static void WriteSourceForProject(ref ZoneProject project, ref Paths paths)
        {
            var sourcePath = GetSourceFolderPath(ref paths);
            Directory.CreateDirectory(sourcePath);
            File.WriteAllText(Path.Combine(sourcePath, $"{project.Map.Name}.CSV"), project.Source);
            File.WriteAllText(Path.Combine(sourcePath, $"{project.Map.Name}_load.CSV"), "material,$levelbriefing\n");
        }

        public static void WriteAdditionalFilesForProject(ref ZoneProject project, bool replaceExistingGSC)
        {
            foreach(var file in project.AdditionalFiles) {
                Directory.CreateDirectory(Path.GetDirectoryName(file.Path));

                if (!replaceExistingGSC && file.Path.EndsWith(".gsc") && File.Exists(file.Path)) {
                    continue;
                }

                File.WriteAllBytes(file.Path, file.Contents);
            }
        }

        public static void WriteArena(string mapName, ref Paths paths)
        {

            var arenaFilePath = GetArenaFilePath(mapName, ref paths);
            Directory.CreateDirectory(Path.GetDirectoryName(arenaFilePath));

            string mapNameShort = mapName.Substring(3).ToUpper();

            string arena = $@"
{{
  map           ""{mapName}""
  longname      ""MPUI_{mapNameShort}""
  gametype      ""dm war sab sab2 dom sd sd2 hc thc ctf koth dd oneflag gtnw""
  description   ""MPUI_DESC_MAP_{mapNameShort}""
  mapimage      ""preview_{mapName}""
  mapoverlay    ""compass_overlay_map_blank ""
  allieschar    ""seals_udt""
  axischar      ""opforce_airborne""
  useteamzones  ""true""
  environment   ""forest""
}}
";

            File.WriteAllText(arenaFilePath, arena);
        }

        public static string[] GetZoneSources(ref Paths paths)
        {
            List<string> sources = new List<string>();
            var zoneSourceRoot = Path.Combine(paths.IW4Path, ZONE_SOURCE_FOLDER);
            Directory.CreateDirectory(zoneSourceRoot);
            string[] files = Directory.GetFiles(zoneSourceRoot);
            foreach (var file in files) {
                if (file.ToUpper().EndsWith(".CSV") && !Path.GetFileNameWithoutExtension(file).EndsWith("_load")) {
                    sources.Add(Path.GetFileNameWithoutExtension(file));
                }
            }

            return sources.ToArray();
        }

        public static bool SourceFileExists(string mapName, ref Paths paths)
        {
            return File.Exists(GetZoneSourcePath(mapName, ref paths));
        }

        public static bool MapFileExists(string mapName, ref Paths paths)
        {
            string usermaps = GetZoneDestinationPath(mapName, ref paths);
            return
                File.Exists(Path.Combine(usermaps, $"{mapName}_load.ff")) &&
                File.Exists(Path.Combine(usermaps, $"{mapName}.ff")) &&
                File.Exists(Path.Combine(usermaps, $"{mapName}.arena"));
        }

        public static void GenerateIWD(string mapName, ref Paths paths, Action<string> pipe)
        {
            // We don't use iw4x.exe iwidump for this because... well it's not really needed!
            // And it's not really more reliable... nor faster

            var iwdPath = Path.Combine(GetZoneDestinationPath(mapName, ref paths), $"{mapName}.iwd");

            pipe.Invoke($"Generating IWD for {mapName}...");

            if (File.Exists(iwdPath)) {
                File.Delete(iwdPath);
            }

            var dataPath = IW3xportHelper.GetDumpDestinationPath(mapName, ref paths);

            using (var zipFile = ZipFile.Open(iwdPath, ZipArchiveMode.Create, Encoding.UTF8)) {
                if (Directory.Exists(dataPath)) {

                    var imagesFolder = Path.Combine(dataPath, "images");
                    if (Directory.Exists(imagesFolder)) {
                        var imageFiles = Directory.GetFiles(imagesFolder);
                        foreach (var file in imageFiles) {
                            string entry = file.Substring(dataPath.Length + 1);

                            if (entry.EndsWith(".iwi")) {
                                pipe.Invoke($"Adding {entry}");
                                zipFile.CreateEntryFromFile(file, entry);
                            }
                        }
                    }

                    var soundFolder = Path.Combine(dataPath, "sound");
                    if (Directory.Exists(soundFolder)) {
                        var soundFiles = Directory.GetFiles(soundFolder, "*.*", SearchOption.AllDirectories);
                        foreach (var file in soundFiles) {
                            string entry = file.Substring(dataPath.Length + 1);
                            pipe.Invoke($"Adding {entry}");
                            zipFile.CreateEntryFromFile(file, entry);
                        }
                    }
                }
            }
            
            pipe.Invoke($"Done! IWD is in {iwdPath}");
        }

        public static void TestMap(string mapName, ref Paths paths)
        {
            string exePath = Path.Combine(paths.IW4Path, EXECUTABLE_NAME);

            var info = new ProcessStartInfo {
                FileName = exePath,
                WorkingDirectory = paths.IW4Path,
                Arguments = string.Join(" ",
                    new string[] {
                        "-console",
                        "-nointro",
                        "-nosteam",
                        "+set scr_game_playerwaittime 0",
                        "+set scr_game_matchstarttime 0",
                        "+set developer 2",
                        "+set developer_script 1",
                        $"+set fs_game mods/{mapName}",
                        $"+devmap {mapName}"
                    }
                ),
                UseShellExecute = false
            };

            if (paths.HasXLabsInstalled()) {
                info.Environment.Add("PATH", $"{Environment.GetEnvironmentVariable("PATH")};{Path.GetDirectoryName(paths.AppDataIW4xLibraryPath)}");
            }

            var proc = new Process { StartInfo = info };
            proc.Start();
        }

        public static string GetArenaFilePath(string mapName, ref Paths paths)
        {
            var exportPath = GetZoneDestinationPath(mapName, ref paths);
            var arenaFilePath = Path.Combine(exportPath, $"{mapName}.arena");
            return arenaFilePath;
        }

        public static int BuildZone(string mapName, ref Paths paths, bool withTeams, Action<string> pipe)
        {
            string sourcePath = GetZoneSourcePath(mapName, ref paths);
            string backupPath = $"{sourcePath}.backup";
            string arenaPath = GetArenaFilePath(mapName, ref paths);

            string destinationPath = GetZoneDestinationPath(mapName, ref paths);

            if (!Directory.Exists(destinationPath)) {
                // Should never happen unless the user has fiddled with files
                // Prevens a nasty error so, better safe than sorry
                Directory.CreateDirectory(destinationPath); 
            }

            if (withTeams) {
                // We need to generate a new zone source and delete it at the end

                if (!File.Exists(arenaPath)) {
                    pipe.Invoke($"Cannot generate map {mapName} with teams because the arena file could not be found!");
                    return -1;
                }
                else {

                    // We need to parse arenafile to get the teams 
                    string[] arenaLines = File.ReadAllLines(arenaPath);
                    HashSet<string> teams = new HashSet<string>();
                    for (int i = 0; i < arenaLines.Length; i++) {
                        string line = arenaLines[i].Trim();
                        if (line.StartsWith("allieschar")) {
                            teams.Add(line.Substring("allieschar".Length).Trim(' ', '"'));
                        }
                        else if (line.StartsWith("axischar")) {
                            teams.Add(line.Substring("axischar".Length).Trim(' ', '"'));
                        }
                    }

                    if (teams.Count > 2) {
                        pipe.Invoke($"Wrong number of teams in arena file: expected 2 teams, got {string.Join(", ", teams)}");
                        return -1;
                    }

                    File.Copy(sourcePath, backupPath, true);

                    var source = File.ReadAllText(sourcePath);
                    StringBuilder sourceBuilder = new StringBuilder(source);

                    // Adding teams
                    foreach (var team in teams) {
                        if (GetZoneSourceForTeam(team, out string additionalSource)) {
                            sourceBuilder.Insert(0, $"# TEAM {team}\n{additionalSource}\n");
                        }
                        else {
                            pipe.Invoke($"Could not find support source in {Environment.CurrentDirectory}{Path.DirectorySeparatorChar}{teamSourceFolder} for team {team}!");
                            return -1;
                        }
                    }

                    File.WriteAllText(sourcePath, sourceBuilder.ToString());
                }
            }

            // Actual building
            string exePath = Path.Combine(paths.IW4Path, EXECUTABLE_NAME);

            var info = new ProcessStartInfo {
                FileName = exePath,
                WorkingDirectory = paths.IW4Path,
                Arguments = string.Join(" ",
                    new string[] {
                        "-zonebuilder",
                        "-stdout",
                        "-nosteam",
                        $"+set fs_game mods/{mapName}",
                        "+set zb_prefer_disk_assets 1",
                        $"+buildzone {mapName}",
                        $"+buildzone {mapName}_load",
                        "+quit"
                    }
                ),
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                RedirectStandardError = true
            };

            if (paths.HasXLabsInstalled()) {
                info.Environment.Add("PATH", $"{Environment.GetEnvironmentVariable("PATH")};{Path.GetDirectoryName(paths.AppDataIW4xLibraryPath)}");
            }

            var proc = new Process { StartInfo = info };
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

            if (withTeams) {
                if (File.Exists(backupPath)) {
                    if (File.Exists(sourcePath)) {
                        File.Delete(sourcePath);
                    }

                    File.Move(backupPath, sourcePath);
                }

                if (proc.ExitCode == 0) {
                    // Remove useteamzones from arenafile
                    if (File.Exists(arenaPath)) {
                        pipe.Invoke($"Removing useteamzones from arenafile at {arenaPath}");
                        string[] arena = File.ReadAllLines(arenaPath);
                        File.WriteAllLines(arenaPath, arena.Where(o => !o.Contains("useteamzones")));
                    }
                }
            }

            int exitCode = proc.ExitCode;

            if (exitCode == 0) {

                string zbOutputPath = Path.Combine(paths.IW4Path, "zonebuilder_out", $"{mapName}");
                string[] filesToMove = {
                    $"{zbOutputPath}.ff",
                    $"{zbOutputPath}_load.ff"
                };

                foreach(var file in filesToMove) {
                    if (File.Exists(file)) {
                        string destination = Path.Combine(destinationPath, Path.GetFileName(file));
                        if (File.Exists(destination)) {
                            File.Delete(destination);
                        }

                        File.Move(file, destination);
                    }
                    else {
                        pipe.Invoke($"Could not find {file} after building!");
                        return -1;
                    }
                }
            }

            return exitCode;
        }

        public static string GetZoneSourcePath(string mapName, ref Paths paths)
        {
            string sourceFolder = Path.Combine(paths.IW4Path, ZONE_SOURCE_FOLDER);
            string sourceFileName = Path.Combine(sourceFolder, $"{mapName}.CSV");

            return sourceFileName;
        }

        public static string GetZoneDestinationPath(string mapName, ref Paths paths)
        {
            string mapFolder = Path.Combine(paths.IW4Path, MAP_DESTINATION_FOLDER, mapName);

            return mapFolder;
        }

        private static bool GetZoneSourceForTeam(string teamName, out string source)
        {
            source = string.Empty;
            Directory.CreateDirectory(teamSourceFolder);

            var files = Directory.GetFiles(teamSourceFolder, "*.csv");
            foreach(var file in files) {
                string sourceName = Path.GetFileNameWithoutExtension(file);
                if (sourceName.ToUpper() == $"iw4x_team_{teamName}".ToUpper()) {
                    source = File.ReadAllText(file);

                    // Remove old require and add a require to the iw4x zone instead!
                    source = $"require,{sourceName}\n{source.Replace("require", "#require")}";

                    return true;
                }
            }

            return false;
        }
    }
}
