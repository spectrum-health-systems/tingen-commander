// u250123_code
// u250123_documentation

using System.IO;

using TingenCommander.Du;

namespace TingenCommander
{
    /// <summary> Do things with the Tingen Commander configuration.</summary>
    internal class Configuration
    {
        /// <summary>The directory where the Tingen web service data is located.</summary>
        public string TngnSvcData { get; set; }

        /// <summary> Load the Tingen Commander configuration file.</summary>
        /// <param name="configFilePath">The path to the Tingen Commander configuration file.</param>
        /// <returns>The Tingen Commander configuration object.</returns>
        internal static Configuration Load(string configFilePath)
        {
            if (!File.Exists(configFilePath))
            {
                Create(configFilePath);
            }

            return DuJson.ImportFromLocalFile<Configuration>(configFilePath);
        }

        /// <summary>Create a default Tingen Commander configuration file.</summary>
        /// <param name="configFilePath">The path to the Tingen Commander configuration file.</param>
        private static void Create(string configFilePath)
        {
            var defaultConfig = Build();

            DuJson.ExportToLocalFile<Configuration>(defaultConfig, configFilePath);
        }

        /// <summary>Build the default Tingen Commander configuration object.</summary>
        /// <returns>A default Tingen Commander configuration object.</returns>
        private static Configuration Build()
        {
            return new Configuration
            {
                TngnSvcData = "T:"
            };
        }
    }
}