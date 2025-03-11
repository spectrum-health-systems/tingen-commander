// u250123_code
// u250123_documentation

using System.IO;

using TingenCommander.Du;

namespace TingenCommander
{
    internal class Environment
    {
        public string SvcVersion { get; set; }
        public string SvcBuild { get; set; }
        public string SvcUpdated{ get; set; }
        public string SvcMode { get; set; }
        public string TraceLogLevel { get; set; }
        public string TraceLogDelay { get; set; }

        internal static Environment Load(string environmentFilePath)
        {
            if (!File.Exists(environmentFilePath))
            {
                Create(environmentFilePath);
            }

            return DuJson.ImportFromLocalFile<Environment>(environmentFilePath);
        }

        internal static void Create(string environmentFilePath)
        {
            var defaultEnvironment = Build();

            DuJson.ExportToLocalFile<Environment>(defaultEnvironment, environmentFilePath);
        }

        internal static Environment Build()
        {
            return new Environment
            {
                SvcVersion    = "YY.MM.x.y",
                SvcBuild      = "YYMMDD.HHMM",
                SvcUpdated    = "MM/DD/YYYY HH:MM:SS AM",
                SvcMode       = "not-set",
                TraceLogLevel = "0",
                TraceLogDelay = "0"
            };
        }
    }
}
