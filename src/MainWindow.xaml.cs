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

            Session cmdrSession = Session.Create();

            cmdrSession.Live =  Environment.Load(cmdrSession.CmdrPath.LiveEnvFile);
            cmdrSession.Uat  =  Environment.Load(cmdrSession.CmdrPath.UatEnvFile);

            SetupMainWindow(cmdrSession);
        }

        internal void SetupMainWindow(Session cmdrSession)
        {
            SetEnvInfo(cmdrSession.Live, lblModeLive, lblVersionLive, lblLastUpdatedLive);
            SetEnvInfo(cmdrSession.Uat, lblModeUat, lblVersionUat, lblLastUpdatedUat);
            SetUserMode(cmdrSession.AdminMode);
        }

        private void SetEnvInfo(Environment sessionDetails, System.Windows.Controls.Label lblTMode, System.Windows.Controls.Label lblTVersion, System.Windows.Controls.Label lblTLastUpdated)
        {
            if (sessionDetails.SvcMode.Equals("enabled", StringComparison.CurrentCultureIgnoreCase))
            {
                SetLabelProperties(lblTMode, "Enabled", Brushes.LightGreen, Brushes.DarkGreen);
            }
            else if (sessionDetails.SvcMode.Equals("disabled", StringComparison.CurrentCultureIgnoreCase))
            {
                SetLabelProperties(lblTMode, "Disabled", Brushes.LightGray, Brushes.Black);;
            }
            else
            {
                SetLabelProperties(lblTMode, "Unknown", Brushes.LightCoral, Brushes.Black);
            }

            lblTVersion.Content     = sessionDetails.SvcVersion; // update name
            // Build goes here
            lblTLastUpdated.Content = sessionDetails.SvcUpdated; // update name
        }

        internal void SetUserMode(bool adminMode)
        {
            if (adminMode)
            {
                SetUserModeControl("Administrator", Brushes.LightGreen, Brushes.DarkGreen);
            }
            else
            {
                SetUserModeControl("Standard User", Brushes.Wheat, Brushes.DarkGreen);
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
    }
}