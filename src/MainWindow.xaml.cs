// ================================================================= 0.1.0 =====
// Tingen Commander: A GUI for Tingen
// Repository: https://github.com/spectrum-health-systems/Tingen-Commander
// Documentation: https://github.com/spectrum-health-systems/Tingen-Documentation
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// ================================================================ 250121 =====

// u250121_code
// u250109_documentation

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

            /* The configuration file path is hard coded for now, and should not be modified.
               */
            const string configPath = @".\AppData\TingenCommanderSettings.json";

            var session = new Session();

            Session.Start(session, configPath);

            SetupMainWindow(session);
        }

        internal void SetupMainWindow(Session session)
        {
            SetUserMode(session.Config.AdminMode);
            SetEnvInfo(session.LiveDetails, lblModeLive, lblVersionLive, lblLastUpdatedLive);
            SetEnvInfo(session.UatDetails, lblModeUat, lblVersionUat, lblLastUpdatedUat);

            //lblMainVersion.Content = session.MainVersion;
            //lblDevVersion.Content  = session.DevVersion;

        }

        private void SetEnvInfo(Environment sessionDetails, System.Windows.Controls.Label lblTMode, System.Windows.Controls.Label lblTVersion, System.Windows.Controls.Label lblTLastUpdated)
        {
            if (sessionDetails.TingenMode.Equals("enabled", StringComparison.CurrentCultureIgnoreCase))
            {
                SetLabelProperties(lblTMode, "Enabled", Brushes.LightGreen, Brushes.DarkGreen);
                //SetEnvironmentStatusControl(lblTMode,"Enabled", Brushes.LightGreen, Brushes.DarkGreen);
            }
            else if (sessionDetails.TingenMode.Equals("disabled", StringComparison.CurrentCultureIgnoreCase))
            {
                SetLabelProperties(lblTMode, "Disabled", Brushes.LightGray, Brushes.Black);
                //SetEnvironmentStatusControl(lblTMode, "Disabled", Brushes.LightGray, Brushes.Black);
            }
            else
            {
                SetLabelProperties(lblTMode, "Unknown", Brushes.LightCoral, Brushes.Black);
                //SetEnvironmentStatusControl(lblTMode, "Unknown", Brushes.LightCoral, Brushes.Black);
            }
            lblTVersion.Content     = sessionDetails.TingenVersion;
            lblTLastUpdated.Content = sessionDetails.TingenLastUpdated;
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
    }
}