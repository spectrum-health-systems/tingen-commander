// ================================================================= 0.1.0 =====
// Tingen Commander: A GUI for Tingen
// Repository: https://github.com/spectrum-health-systems/Tingen-Commander
// Documentation: https://github.com/spectrum-health-systems/Tingen-Documentation
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// ================================================================ 250109 =====

// b250109.1120
// u250109_code
// u250109_documentation

using System.Windows;
using System.Windows.Media;

namespace TingenCommander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //internal Session CmdrSesh { get; set; }


        public MainWindow()
        {
            InitializeComponent();

            /* The configuration file path is hard coded for now, and should not be modified.
               */
            const string configPath = @".\AppData\TingenCommanderSettings.json";

            var session = new Session();

            Session.Start(session, configPath);

            SetupWindow(session);
        }

        internal void SetupWindow(Session session)
        {
            // Overview

            if (session.LiveDetails.TingenMode.ToLower() == "enabled")
            {
                lblOverviewTingenMode.Content = "Enabled";
                lblOverviewTingenMode.Background = Brushes.LightGreen;
                lblOverviewTingenMode.Foreground = Brushes.DarkGreen;
                btnOverviewLiveToggleMode.Content = "Disable";
            }
            else
            {
                lblOverviewTingenMode.Content = "Disabled";
                lblOverviewTingenMode.Background = Brushes.LightCoral;
                lblOverviewTingenMode.Foreground = Brushes.DarkRed;
                btnOverviewLiveToggleMode.Content = "Enable";
            }

                // Environments

                lblMainVersion.Content = session.MainVersion;
            lblDevVersion.Content  = session.DevVersion;
            lblLiveTingenVersion.Content = session.LiveDetails.TingenVersion;
            lblLiveLastUpdated.Content = session.LiveDetails.TingenLastUpdated;
            lblLiveTingenMode.Content = session.LiveDetails.TingenMode;
        }
    }
}