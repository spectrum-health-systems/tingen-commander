// u250121_code
// u250109_documentation

using System.IO;
using System.Windows;
using System;

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

            /* Administrator mode is only available when Tingen Commander is run on the same machine that hosts the Tingen web service.
               * The Tingen web service stores data in the "C:\TingenData" directory, which is hardcoded here since that's where it should
               * always be located.
               */
            const string adminModePath = @"C:\TingenData\";

            if (cmdrSesh.Config.AdminMode)
            {
                if (Directory.Exists(adminModePath))
                {
                    cmdrSesh.Config.TingenDataRoot = adminModePath;
                }
                else
                {
                    var msg = Catalog.MsgAdminModeError();

                    MessageBox.Show(msg, "Administrator mode error!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Application.Current.Shutdown(2);
                }
            }
            else
            {
                if (!Directory.Exists(cmdrSesh.Config.TingenDataRoot))
                {
                    var msg = Catalog.MsgStandardModeError(cmdrSesh.Config.TingenDataRoot);

                    MessageBox.Show(msg, "Standard User mode error!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Application.Current.Shutdown(2);
                }

                //cmdrSesh.Config.TingenDataRoot = @"T:\";
            }


            Reset(cmdrSesh.Config.SessionRoot);

            cmdrSesh.MainVersion = Repository.Asmx.GetVersion(cmdrSesh.Config.SessionRoot, cmdrSesh.Config.MainUrl);
            cmdrSesh.DevVersion  = Repository.Asmx.GetVersion(cmdrSesh.Config.SessionRoot, cmdrSesh.Config.DevUrl);

            var liveSettingsFile = $@"{cmdrSesh.Config.TingenDataRoot}\Admin\LIVE.commander";

            cmdrSesh.LiveDetails = Environment.GetEnvironmentDetails(liveSettingsFile);

            var uatSettingsFile = $@"{cmdrSesh.Config.TingenDataRoot}\Admin\UAT.commander";

            cmdrSesh.UatDetails = Environment.GetEnvironmentDetails(uatSettingsFile);
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