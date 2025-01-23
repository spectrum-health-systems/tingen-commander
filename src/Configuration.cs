// u250121_code
// u250109_documentation

using System.IO;

using TingenCommander.Du;

namespace TingenCommander
{
    /// <summary>
    /// Do things with the Tingen Commander configuration.
    /// </summary>
    internal class Configuration
    {
        public string SessionRoot { get; set; }
        public string TngnData { get; set; }

        public string MainUrl { get; set; }
        public string DevUrl { get; set; }

        internal static Configuration Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Create(filePath);
            }

            return DuJson.ImportFromLocalFile<Configuration>(filePath);
        }

        private static void Create(string filePath)
        {
            var defaultConfig = Build();

            DuJson.ExportToLocalFile(defaultConfig, filePath);
        }

        private static Configuration Build()
        {
            return new Configuration
            {
                SessionRoot    = @".\AppData\Session",
                TngnData = "T:",
                MainUrl        = "https://raw.githubusercontent.com/spectrum-health-systems/Tingen-Development/refs/heads/main/src/Tingen_development.asmx.cs",
                DevUrl         = "https://raw.githubusercontent.com/spectrum-health-systems/Tingen-Development/refs/heads/development/src/Tingen_development.asmx.cs"
            };
        }
    }
}