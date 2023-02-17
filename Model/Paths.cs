namespace MapPortingUtility
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Serializable]
    public struct Paths
    {
        public string IW4Path { get; set; }

        public string IW3Path { get; set; }

        public string IW5Path { get; set; }

        public string AppDataIW4xLibraryPath => Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "xlabs", "data", "iw4x", "iw4x.dll"
        );

        private static readonly string[] mandatoryIW4Files = new string[] {
            "main", "zone", "iw4x.exe"
        };

        private static readonly string[] mandatoryIW3Files = new string[] {
            "main", "zone", "iw3xport.exe", "iw3mp.exe", "iw3x.dll"
        };

        private static readonly string[] mandatoryIW5Files = new string[] {
            "main", "zone", "open-iw5.exe", "mss32.dll", "binkw32.dll"
        };

        public bool IsValid => IsIW4PathGood(out _) && (IsIW3PathGood(out _) || IsIW5PathGood(out _));

        public bool HasXLabsInstalled()
        {
            return File.Exists(AppDataIW4xLibraryPath);
        }

        public bool IsIW4PathGood(out string error)
        {
            error = string.Empty;

            if (!Directory.Exists(IW4Path)) {
                error = "No such file or directory!";
                return false;
            }

            for (int i = 0; i < mandatoryIW4Files.Length; i++) {
                string path = Path.Combine(IW4Path, mandatoryIW4Files[i]);
                if (!File.Exists(path) && !Directory.Exists(path)) {
                    error = $"Missing critical file/directory {mandatoryIW4Files[i]}";
                    return false;
                }
            }

#if !DEBUG
            if (!HasXLabsInstalled()) {
                error = "XLabs has never been launched on this computer! Please launch the game at least once through the XLabs Launcher before using this tool to create the necessary files.";
                return false;
            }
#endif

            return true;
        }


        public bool IsIW3PathGood(out string error)
        {
            error = string.Empty;

            if (!Directory.Exists(IW3Path)) {
                error = "No such file or directory!";
                return false;
            }

            for (int i = 0; i < mandatoryIW3Files.Length; i++) {
                string path = Path.Combine(IW3Path, mandatoryIW3Files[i]);
                if (!File.Exists(path) && !Directory.Exists(path)) {
                    error = $"Missing critical file/directory {mandatoryIW3Files[i]}";
                    return false;
                }
            }

            return true;
        }
        public bool IsIW5PathGood(out string error)
        {
            error = string.Empty;

            if (!Directory.Exists(IW5Path))
            {
                error = "No such file or directory!";
                return false;
            }

            for (int i = 0; i < mandatoryIW5Files.Length; i++)
            {
                string path = Path.Combine(IW5Path, mandatoryIW5Files[i]);
                if (!File.Exists(path) && !Directory.Exists(path))
                {
                    error = $"Missing critical file/directory {path}";
                    return false;
                }
            }

            return true;
        }

        public bool TryDetectIW5Path()
        {
            string[] candidates = {
                @"C:\Program Files\Steam\steamapps\common\Call of Duty Modern Warfare 3",
                @"C:\Program Files (x86)\Activision\Call of Duty Modern Warfare 3",
                @"D:\Games\Call of Duty Modern Warfare 3",
            };

            for (int i = 0; i < candidates.Length; i++)
            {
                IW5Path = candidates[i];
                if (IsIW5PathGood(out _))
                {
                    return true;
                }
            }

            IW5Path = string.Empty;
            return false;
        }


        public bool TryDetectIW3Path()
        {
            string[] candidates = {
                @"C:\Program Files\Steam\steamapps\common\Call of Duty 4",
                @"C:\Program Files\Activision\Call of Duty 4 - Modern Warfare",
                @"C:\Program Files (x86)\Activision\Call of Duty 4 - Modern Warfare",
                @"D:\Games\Call of Duty 4 - Modern Warfare",
                $@"C:\Users\{Environment.UserName}\AppData\Local\VirtualStore\Program Files\Activision\Call of Duty 4 - Modern Warfare",
                $@"C:\Users\{Environment.UserName}\AppData\Local\VirtualStore\Program Files (x86)\Activision\Call of Duty 4 - Modern Warfare"
            };

            for (int i = 0; i < candidates.Length; i++) {
                IW3Path = candidates[i];
                if (IsIW3PathGood(out _)) {
                    return true;
                }
            }

            IW3Path = string.Empty;
            return false;
        }

        public bool TryDetectIW4Path()
        {
            var regCandidate = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Classes\iw4x\shell\open\command");

            if (regCandidate != null) {
                string regPath = (string)regCandidate.GetValue(regCandidate.GetValueNames()[0]);
                int length = regPath.IndexOf("\" \"%1\"");
                regPath = regPath.Substring(1, length-1);
                regPath = Path.GetDirectoryName(regPath);
                IW4Path = regPath;
                if (IsIW4PathGood(out _)) {
                    return true;
                }
            }

            string[] candidates = {
                @"D:\Games\iw4x_full_game",
                @"C:\Games\iw4x_full_game",
                @"C:\Games\IW4x",
                @"C:\Program Files (x86)\Steam\steamapps\common\Modern Warfare 2",
                @"C:\Program Files (x86)\Steam\steamapps\common\Call of Duty Modern Warfare 2",
            };

            for (int i = 0; i < candidates.Length; i++) {
                IW4Path = candidates[i];
                if (IsIW4PathGood(out _)) {
                    return true;
                }
            }

            IW4Path = string.Empty;
            return false;
        }
    }
}
