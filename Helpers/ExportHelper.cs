namespace MapPortingUtility
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class ExportHelper
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

        protected static readonly string[] CANONICAL_LANGUAGES = new string[]
        {
            "english","french","german","spanish","japanese","russian","italian","dlc"
        };

        protected const string MAP_PREFIX_FILTER = "mp_";
        protected const string MAP_SUFFIX_FILTER = "_load";
        protected const string MAP_EXT_FILTER = ".ff";
        protected static readonly string CANONICAL_MAP_DIRECTORY_FMT = Path.Combine("zone", "{0}");
        protected static readonly string USERMAPS_MAP_DIRECTORY = Path.Combine("usermaps");

        public static string GetDumpDestinationPath(ref Map map, ref Paths paths) => GetDumpDestinationPath(map.Name, ref paths);
        public static string GetDumpDestinationPath(string mapName, ref Paths paths) => Path.Combine(paths.IW4Path, "mods", mapName);
    }
}
