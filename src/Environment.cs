// u250121_code
// u250109_documentation

using System.IO;

namespace TingenCommander
{
    internal class Environment
    {
        public string ServiceVersion { get; set; }
        public string ServiceLastUpdated { get; set; }
        public string ServiceMode { get; set; }
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
                //if (item.StartsWith("Service version:")) // put ":" in document
                //{
                //    environmentDetails.TingenVersion = item.Replace("Service version:", "").Trim();
                //}
                //else if (item.StartsWith("Service updated:"))
                //{
                //    environmentDetails.TingenLastUpdated = item.Replace("Service updated:", "").Trim();
                //}
                //else if (item.StartsWith("Service mode:"))
                //{
                //    environmentDetails.TingenMode = item.Replace("Service mode:", "").Trim();
                //}
                //else if (item.StartsWith("Trace log level:"))
                //{
                //    environmentDetails.TraceLevel = item.Replace("Trace log level:", "").Trim();
                //}
                //else if (item.StartsWith("Trace log delay:"))
                //{
                //    environmentDetails.TraceDelay = item.Replace("Trace log delay:", "").Trim();
            }
            return environmentDetails;
        }
    }
}
