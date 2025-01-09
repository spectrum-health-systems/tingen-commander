// b250109.1447
// u250109_code
// u250109_documentation

using System.IO;

namespace TingenCommander
{
    internal class Environment
    {
        public string TingenVersion { get; set; }
        public string TingenLastUpdated { get; set; }
        public string TingenMode { get; set; }
        public string TraceLevel { get; set; }
        public string TraceDelay { get; set; }

        internal static Environment GetEnvironmentDetails(string filePath)
        {
            string[] rawData = null;

            Environment environmentDetails = new();

            if (File.Exists(filePath))
            {
                rawData = File.ReadAllLines(filePath);
            }

            foreach (var item in rawData)
            {
                if (item.StartsWith("> Version")) // put ":" in document
                {
                    environmentDetails.TingenVersion = item.Replace("> Version", "").Trim();
                }
                else if (item.StartsWith("> Last updated:"))
                {
                    environmentDetails.TingenLastUpdated = item.Replace("> Last updated:", "").Trim();
                }
                else if (item.StartsWith("Mode:"))
                {
                    environmentDetails.TingenMode = item.Replace("Mode:", "").Trim();
                }
                else if (item.StartsWith("Trace log level:"))
                {
                    environmentDetails.TraceLevel = item.Replace("Trace log level:", "").Trim();
                }
                else if (item.StartsWith("Trace log delay:"))
                {
                    environmentDetails.TraceDelay = item.Replace("Trace log delay:", "").Trim();
                }
            }

            return environmentDetails;
        }
    }
}
