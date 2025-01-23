// u250123_code
// u250123_documentation

using System.IO;
using System.Windows;

namespace TingenCommander
{
    /// <summary>
    /// Session details.
    /// </summary>
    internal class Session
    {
        public Dictionary<string, string> CmdrPath { get; set; }
        public Configuration Config { get; set; }
        public string SessionDataRoot { get; set; }
        public string TingenDataRoot
        public Repository Repo { get; set; }
        public Environment Live { get; set; }
        public Environment Uat  { get; set; }

        internal static Session Start()
        {
            Paths cmdrPaths = new();

            Paths.Initialize(cmdrPaths);

            Configuration cmdrConfig = Configuration.Load(cmdrPaths.CmdrConfigFile);

            Paths.Update(cmdrPaths, cmdrConfig.TngnData);




            //Session cmdrSesh = new();

            //Configuration commanderConfig = Configuration.Load(configPath);

            //x cmdrSesh.Config = Configuration.Load(configPath);



            ////////Reset(commanderConfig.TingenDataRoot);

            ////////var liveSettingsFile = $@"{commanderConfig.TingenDataRoot}\Admin\LIVE.commander";

            ////////var uatSettingsFile = $@"{commanderConfig.TingenDataRoot}\Admin\UAT.commander";


            //Session newSession = new()
            //{
            //    Config      = commanderConfig,
            //    Live = Environment.GetEnvironmentDetails(liveSettingsFile),
            //    Uat  = Environment.GetEnvironmentDetails(uatSettingsFile),
            //    MainVersion = Repository.Asmx.GetVersion(commanderConfig.SessionRoot, commanderConfig.MainUrl),
            //    DevVersion  = Repository.Asmx.GetVersion(commanderConfig.SessionRoot, commanderConfig.DevUrl)
            //};


            //cmdrSesh.MainVersion = Repository.Asmx.GetVersion(cmdrSesh.Config.SessionRoot, cmdrSesh.Config.MainUrl);
            //cmdrSesh.DevVersion  = Repository.Asmx.GetVersion(cmdrSesh.Config.SessionRoot, cmdrSesh.Config.DevUrl);


            Session newSession = new();
            return newSession;
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