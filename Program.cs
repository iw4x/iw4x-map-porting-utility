namespace MapPortingUtility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal static class Program
    {
        public const string PATHS_FILE_NAME = "PATHS.YML";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static bool ReadPaths(out Paths paths)
        {
            paths = new Paths();

            if (System.IO.File.Exists(PATHS_FILE_NAME)) {
                try {
                    var deserializer = new YamlDotNet.Serialization.DeserializerBuilder()
                        .IgnoreUnmatchedProperties()
                        .IgnoreFields()
                        .Build();
                    paths = deserializer.Deserialize<Paths>(System.IO.File.ReadAllText(PATHS_FILE_NAME));

                    return true;
                }
                catch {
                    return false;
                }
            }

            return false;
        }

        public static void WritePaths(Paths paths)
        {
            var serializer = new YamlDotNet.Serialization.SerializerBuilder()
                .IgnoreFields()
                .Build();

            try {
                string pathsStr = serializer.Serialize(paths);
                System.IO.File.WriteAllText(PATHS_FILE_NAME, pathsStr);
            }
            catch (Exception e) {
                MessageBox.Show($"An error occured while writing paths:\n{e}\n\nYou may have to configure your paths again next time you launch the program", "Error while writing paths", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
