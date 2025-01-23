// ================================================================= 0.1.0 =====
// Tingen Commander: A GUI for Tingen
// Repository: https://github.com/spectrum-health-systems/Tingen-Commander
// Documentation: https://github.com/spectrum-health-systems/Tingen-Documentation
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// ================================================================ 250123 =====

// u250123_code
// u250123_documentation

using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Reflection.Emit;

namespace TingenCommander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Session.Start();

            //CommanderPaths cmdrPath = CommanderPaths.Initialize();

           
            
            //Session.SetCommanderPaths(commanderPaths);



            //const string commanderDataPath = @".\AppData\";
            //const string configPath = $@"{commanderDataPath}\TingenCommanderSettings.json";




           // Session session = Session.Start(configPath, serverPath);

            //SetupMainWindow(session);
        }

        internal void SetupMainWindow(Session session)
        {
            SetEnvInfo(session.Live, lblModeLive, lblVersionLive, lblLastUpdatedLive);
            SetEnvInfo(session.Uat, lblModeUat, lblVersionUat, lblLastUpdatedUat);

            //lblMainVersion.Content = session.MainVersion;
            //lblDevVersion.Content  = session.DevVersion;

        }

        private void SetEnvInfo(Environment sessionDetails, System.Windows.Controls.Label lblTMode, System.Windows.Controls.Label lblTVersion, System.Windows.Controls.Label lblTLastUpdated)
        {
            //if (sessionDetails.TingenMode.Equals("enabled", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    SetLabelProperties(lblTMode, "Enabled", Brushes.LightGreen, Brushes.DarkGreen);
            //    //SetEnvironmentStatusControl(lblTMode,"Enabled", Brushes.LightGreen, Brushes.DarkGreen);
            //}
            //else if (sessionDetails.TingenMode.Equals("disabled", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    SetLabelProperties(lblTMode, "Disabled", Brushes.LightGray, Brushes.Black);
            //    //SetEnvironmentStatusControl(lblTMode, "Disabled", Brushes.LightGray, Brushes.Black);
            //}
            //else
            //{
            //    SetLabelProperties(lblTMode, "Unknown", Brushes.LightCoral, Brushes.Black);
            //    //SetEnvironmentStatusControl(lblTMode, "Unknown", Brushes.LightCoral, Brushes.Black);
            //}
            //lblTVersion.Content     = sessionDetails.TingenVersion;
            //lblTLastUpdated.Content = sessionDetails.TingenLastUpdated;
        }

        //private void SetEnvironmentControls(Label lblTMode, string mode, Label lblTVersion, string version, Label lblTLastUpdated, string lastUpdated)
        //{
        //    lblTMode.Content    = "Enabled";
        //    lblTMode.Background = Brushes.LightGreen;
        //    lblTMode.Foreground = Brushes.DarkGreen;
        //}

        private void SetEnvironmentStatusControl(System.Windows.Controls.Label status, string mode, Brush background, Brush foreground)
        {
                status.Content    = mode;
                status.Background = background;
                status.Foreground = foreground;
        }

        internal void SetUserMode(bool adminMode)
        {
            if (adminMode)
            {
                //SetUserModeControl("Administrator", Brushes.LightGreen, Brushes.DarkGreen);
                //SetLabelProperties(System.Windows.Controls.Label lblCommanderMode, "Administrator", Brushes.LightGreen, Brushes.DarkGreen);
            }
            else
            {
                //SetUserModeControl("Standard user", Brushes.Wheat, Brushes.DarkGreen);
            }
        }

        internal void SetUserModeControl(string content, Brush background, Brush foreground)
        {
            lblCommanderMode.Content    = content;
            lblCommanderMode.Background = background;
            lblCommanderMode.Foreground = foreground;
        }

        internal void SetLabelProperties(System.Windows.Controls.Label label, string content, Brush background, Brush foreground)
        {
            label.Content    = content;
            label.Background = background;
            label.Foreground = foreground;
        }

        /// <summary>
        /// Set constants.
        /// </summary>
        /// <returns></returns>
        //internal Dictionary<string, string> SetCommanderPaths()
        //{
        //    /*XMLDOC
        //       * There are a bunch of paths that need to be set when Tingen Commander runs, and we will set them here so they are all in one
        //       * place.
        //       *
        //       * The configuration file should always be located in the "TingenCommander\AppData\" directory.
        //       *
        //       * Tingen Commander has two modes:
        //       *
        //       * 1. Standard User mode
        //       * 2. Administrator mode
        //       *
        //       * By default, Tingen Commander runs in "Standard User mode", which disables some of the more advanced features.
        //       *
        //       * When run on the server that hosts the Tingen web service, Tingen Commander runs in "Administrator mode", which enables all
        //       * features.
        //       */

        //    const string commanderRoot = @".\AppData";

        //    Dictionary<string, string> commanderPaths = new()
        //    {
        //        { "configPath",        $@"{commanderRoot}\TingenCommanderSettings.json" },
        //        { "serverPath",        $@"C:\TingenData\" },
        //        { "liveCommanderFile", $@"{commanderRoot}\Admin\LIVE.commander" },
        //        { "uatCommanderFile",  $@"{commanderRoot}\Admin\UAT.commander" }
        //    };

        //    return commanderPaths;
        //}
    }
}