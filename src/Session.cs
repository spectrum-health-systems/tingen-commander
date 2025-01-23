// u250123_code
// u250123_documentation

using System.IO;

namespace TingenCommander
{
    /// <summary>The Tingen session object, and stuff related to it.</summary>
    internal class Session
    {
        public bool AdminMode { get; set; }
        /// <summary>A dictionary of paths required by Tingen Commander.</summary>
        public Paths CmdrPath { get; set; }

        /// <summary>The Tingen Commander configuration object.</summary>
        public Configuration Config { get; set; }

        /// <summary>The Tingen Commander repository object.</summary>
        /// <remarks>Not currently used.</remarks>
        public Repository Repo { get; set; }

        /// <summary>The Tingen Commander environment object for LIVE.</summary>
        public Environment Live { get; set; }

        /// <summary>The Tingen Commander environment object for UAT./summary>
        public Environment Uat  { get; set; }

        /// <summary>Starts a new Tingen Commander session.</summary>
        /// <returns>The session object.</returns>
        internal static Session Create()
        {
            Paths cmdrPaths = new();

            Paths.Initialize(cmdrPaths);

            Configuration cmdrConfig = Configuration.Load(cmdrPaths.CmdrConfigFile);

            Paths.Update(cmdrPaths, cmdrConfig.TngnSvcData);

            Session cmdrSession = new Session
            {
                CmdrPath = cmdrPaths,
                Config   = cmdrConfig,
                Repo     = new Repository()
            };

            cmdrSession.AdminMode = cmdrPaths.TngnSvcData == cmdrPaths.AdminModePath;

            return cmdrSession;
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