// u250123_code
// u250123_documentation

using System.IO;
using System.Windows;

using TingenCommander;

namespace TingenCommander
{
    internal class Paths
    {
        public string CmdrRoot { get; set; }
        public string CmdrSessionRoot { get; set; }
        public string CmdrConfigFile { get; set; }
        public string TngnDataRoot { get; set; }
        public string TngnAdminModePath { get; set; }
        public string LiveDetailFile { get; set; }
        public string UatDetailFile { get; set; }

        internal static Paths Initialize(Paths paths)
        {
            const string cmdrRoot = @".\AppData";

            paths.CmdrRoot          = cmdrRoot;
            paths.CmdrConfigFile    = $@"{cmdrRoot}\TingenCommanderSettings.json";
            paths.TngnAdminModePath = @"C:\TingenData";

            return paths;
        }

        internal static Paths Update(Paths paths, string tngnData)
        {
            var tngnDataPath = SetTngnDataPath(paths.TngnAdminModePath, tngnData);

            paths.TngnDataRoot   = tngnDataPath;
            paths.LiveDetailFile = $@"{tngnDataPath}\Admin\LIVE.commander";
            paths.UatDetailFile  = $@"{tngnDataPath}\Admin\UAT.commander";

            return paths;
        }

        internal static string SetTngnDataPath(string tngnServer, string tngnData)
        {
            if (Directory.Exists(tngnServer))
            {
                return tngnServer;
            }
            else if (!Directory.Exists(tngnData))
            {
                var msg = Catalog.ModeError(tngnData);
                MessageBox.Show(msg, "Missing required directories!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return "";
        }
    }
}


/*XMLDOC
   * There are a bunch of paths that need to be set when Tingen Commander runs, and we will set them here so they are all in one
   * place.
   *
   * The configuration file should always be located in the "TingenCommander\AppData\" directory, so that's hard coded here.
   *
   * When Tingen Commander starts, the commanderPaths dictionary is empty, so the following entries are created:
   *
   *    - configPath
   *    - serverPath
   *
   * Tingen Commander has two modes:
   *
   * 1. Standard User mode
   * 2. Administrator mode
   *
   * By default, Tingen Commander runs in "Standard User mode", which disables some of the more advanced features.
   *
   * When run on the server that hosts the Tingen web service, Tingen Commander runs in "Administrator mode", which enables all
   * features.
   */