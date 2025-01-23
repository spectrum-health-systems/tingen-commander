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

        /// <summary>Create the initial Tingen Commander paths.</summary>
        /// <param name="paths">The dictionary that contains  the Tingen Commander paths.</param>
        /// <remarks>
        ///   <para>
        ///     When Tingen Commander starts, we setup some foundational paths that are used throughout the application:
        ///     <list type="bullet">
        ///       <item>CmdrRoot:</item>
        ///       <description>The root directory for Tingen Commander.</description>
        ///       <item>CmdrConfigFile:</item>
        ///       <description>The full path to the "TingenCommanderSettings.json" configuration file.</description>
        ///       <item>TngnAdminModePath:</item>
        ///       <description>The TingenData path on a server hosting the Tingen web service".</description>
        ///     </list>
        ///   </para>
        ///   <para>
        ///   By design, any server that hosts the Tingen web service has a directory named "C:\TingenData", where<br/>
        ///   Tingen-related data is stored. If you run Tingen Commander on a machine that has a "C:\TingenData", Tingen<br/>
        ///   Commander will run in "Administrator  Mode", which enables all functionality.<br/>
        ///   <br/>
        ///   If the "C:\TingenData" directory does not exist, Tingen Commander will run in "Standard User Mode".
        ///   </para>
        /// </remarks>
        /// <returns>A dictionary containing the initial Tingen Commander paths. </returns>
        internal static Paths Initialize(Paths paths)
        {
            /* The cmdrRoot is hard-coded as ".\AppData", and should not be modified.
               */
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