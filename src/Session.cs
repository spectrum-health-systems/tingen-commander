// b250109.1128
// u250109_code
// u250109_documentation

using System.IO;

namespace TingenCommander
{
    internal class Session
    {
        public Configuration Config { get; set; }
        public string MainVersion { get; set; }
        public string DevVersion { get; set; }
        public Environment LiveDetails { get; set; }
        public Environment UatDetails { get; set; }

        internal static void Start(Session cmdrSesh, string configPath)
        {
            cmdrSesh.Config = Configuration.Load(configPath);

            Reset(cmdrSesh.Config.SessionRoot);

            cmdrSesh.MainVersion = Repository.Asmx.GetVersion(cmdrSesh.Config.SessionRoot, cmdrSesh.Config.MainUrl);
            cmdrSesh.DevVersion  = Repository.Asmx.GetVersion(cmdrSesh.Config.SessionRoot, cmdrSesh.Config.DevUrl);

            var liveSettingsFile = $@"{cmdrSesh.Config.TingenDataRoot}\Remote\Current-Tingen-LIVE-settings.md";

            cmdrSesh.LiveDetails = Environment.GetEnvironmentDetails(liveSettingsFile);



        }

        internal static void Reset(string sessionRoot)
        {
            if (Directory.Exists(sessionRoot))
            {
                Directory.Delete(sessionRoot, true);
            }

            Directory.CreateDirectory(sessionRoot);
        }
    }
}