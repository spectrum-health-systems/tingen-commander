// u250123_code
// u250123_documentation

using System.IO;
using System.Windows;

namespace TingenCommander
{
    internal class Paths
    {
        public string CmdrData { get; set; }
        public string CmdrSessionData { get; set; }
        public string CmdrConfigFile { get; set; }
        public string TngnSvcData { get; set; }
        public string AdminModePath { get; set; }
        public string LiveEnvFile { get; set; }
        public string UatEnvFile { get; set; }

        /// <summary>Create the initial Tingen Commander paths.</summary>
        /// <param name="cmdrPath">The dictionary that contains  the Tingen Commander paths.</param>
        /// <remarks>
        ///   <para>
        ///     When Tingen Commander starts, we setup some foundational paths that are used throughout the application:
        ///     <list type="bullet">
        ///       <item>CmdrData:</item>
        ///       <description>The directory Tingen Commander stores local data.</description>
        ///       <item>CmdrConfigFile:</item>
        ///       <description>The full path to the "TingenCommanderSettings.json" configuration file.</description>
        ///       <item>AdminModePath:</item>
        ///       <description>The TingenData path on a server hosting the Tingen web service".</description>
        ///     </list>
        ///   </para>
        ///   <para>
        ///   By design, any server that hosts the Tingen web service has a directory named <c>"C:\TingenData"</c>, where<br/>
        ///   Tingen-related data is stored. If you run Tingen Commander on a machine that has a <c>"C:\TingenData"</c>,<br/>
        ///   Tingen Commander will run in "Administrator Mode", which enables all functionality.<br/>
        ///   <br/>
        ///   If the <c>"C:\TingenData"</c> directory does not exist, Tingen Commander will run in "Standard User Mode".<br/>
        ///   <br/>
        ///   The <c>Paths.Update()</c> method will build upon this later.
        ///   </para>
        /// </remarks>
        /// <returns>A dictionary containing the initial Tingen Commander paths.</returns>
        internal static Paths Initialize(Paths cmdrPath)
        {
            /* The cmdrRoot is hard-coded as ".\AppData", and should not be modified.
               */
            const string cmdrRoot = @".\AppData";

            cmdrPath.CmdrData       = cmdrRoot;
            cmdrPath.CmdrConfigFile = $@"{cmdrRoot}\TingenCommanderSettings.json";
            cmdrPath.AdminModePath  = @"C:\TingenData";

            return cmdrPath;
        }

        /// <summary> Update the Tingen Commander paths dictionary.</summary>
        /// <param name="cmdrPath">The dictionary that contains  the Tingen Commander paths.</param>
        /// <param name="tngnSvcData">The path to Tingen Data location.</param>
        /// <remarks>
        ///   <para>
        ///     The <c>Paths.Initialize()</c> method creates the initial Tingen Commander paths, and this method builds<br/>
        ///     upon those, concentrating on the following:
        ///     <list type="bullet">
        ///       <item>TngnServiceData:</item>
        ///       <description>The directory where the Tingen web service stores data.</description>
        ///       <item>LiveCommanderFile:</item>
        ///       <description>The full path to the "LIVE.commander" file.</description>
        ///       <item>UatCommanderFile:</item>
        ///       <description>The full path to the "UAT.commander" file.</description>
        ///     </list>
        ///   </para>
        ///   <para>
        ///     We need to know the true value of <c>TngnDataRoot</c>, in order to set most of the remaining paths.<br/>
        ///     <c>TngnSvcData</c> can either be <c>"C:\TingenData"</c> or the path defined in the configuration<br/>
        ///     file, depending which exists (or if <c>TngnDataRoot</c> exists first.
        ///   </para>
        /// </remarks>
        /// <returns>A dictionary containing updated Tingen Commander paths.</returns>
        internal static Paths Update(Paths cmdrPath, string tngnSvcData)
        {
            var trueTngnDataRoot = SetTngnDataPath(cmdrPath.AdminModePath, tngnSvcData);

            cmdrPath.TngnSvcData = trueTngnDataRoot;
            cmdrPath.LiveEnvFile = $@"{trueTngnDataRoot}\Commander\LIVE.json";
            cmdrPath.UatEnvFile  = $@"{trueTngnDataRoot}\Commander\UAT.json";

            return cmdrPath;
        }

        /// <summary>Determine the true path to Tingen Data.</summary>
        /// <param name="adminModePath">The TingenData path on a server hosting the Tingen web service.</param>
        /// <param name="configTngnSvcData">The TingenData path defined in the Tingen Commander configuration file.</param>
        /// <remarks>
        ///   <para>
        ///     When Tingen Commander starts, it needs to know where the Tingen web service stores it's data. In general,<br/>
        ///     when you run Tingen Commander on a workstation, that location will be what is defined in the configuration<br/>
        ///     file. However, if you run Tingen Commander on the server that hosts the Tingen web service, the location<br/>
        ///     will be <c>C:\TingenData</c>.<br/>
        ///     <br/>
        ///     This method sets:
        ///     <list type="bullet">
        ///       <item>
        ///         If <c>C:\TingenData</c> exists, <c>TngnSvcData</c> is set to <c>C:\TingenData</c>
        ///       </item>
        ///       <item>
        ///         If <c>C:\TingenData</c> does not not exist, but the path defined in the configuration file does,<br/>
        ///         <c>TngnSvcData</c> is set to the value in the configuration file.
        ///       </item>
        ///       <item>
        ///         If neither <c>C:\TingenData</c> nor the value in the configuration file exist, the user is
        ///         notified, and Tingen Commander exits.
        ///       </item>
        ///     </list>
        ///   </para>
        /// </remarks>
        /// <returns>The true path to Tingen Data.</returns>
        internal static string SetTngnDataPath(string adminModePath, string configTngnSvcData)
        {
            if (Directory.Exists(adminModePath))
            {
                return adminModePath;
            }
            else if (Directory.Exists(configTngnSvcData))
            {
                return configTngnSvcData;
            }
            else
            {
                var msg = Catalog.MsgTngnDataLocationNotFound(configTngnSvcData);

                MessageBox.Show(msg, "Missing required directories!", MessageBoxButton.OK, MessageBoxImage.Error);
                System.Environment.Exit(1);
            }

            return "";
        }
    }
}