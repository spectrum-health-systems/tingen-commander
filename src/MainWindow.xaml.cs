// ================================================================= 0.9.0 =====
// Tingen Commander: A GUI for Tingen
// Repository: https://github.com/spectrum-health-systems/Tingen-Commander
// Documentation: https://github.com/spectrum-health-systems/Tingen-Documentation
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// ================================================================ 241217 =====

// u241217.1132_code
// u241217_documentation

using System.Reflection;
using System.Windows;

using TingenLieutenant;

namespace TingenCommander
{
    /// <summary>Interaction logic for MainWindow.xaml</summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /* This shouldn't be modified.
             */
            const string configFilePath = @".\AppData\TingenCommanderSettings.json";

            Sesh tcmdrSesh = Sesh.LoadConfiguration(configFilePath);

            Sesh.ResetSessionData(tcmdrSesh.SessionRoot);

            SetWindowTitle("Alpha");

            Repository.DownloadAsmxFiles(tcmdrSesh.SessionRoot, tcmdrSesh.MainBranchUrl, tcmdrSesh.DevelopmentBranchUrl);

            SetRepositoryVersions(tcmdrSesh.SessionRoot);



            SetUatInformation();

            var t = 0;
        }

        /// <summary>Build the Tingen Commander version information.</summary>
        /// <param name="postfix">The release stage (e.g., "Alpha", "Beta")</param>
        /// <remarks>
        /// If <c>releaseStage</c> is passed as an empty string (e.g., <c>""</c>), only the version number will be used.
        /// </remarks>
        /// <returns>The Tingen Commander version string.</returns>
        private void SetWindowTitle(string postfix)
        {
            if (string.IsNullOrWhiteSpace(postfix))
            {
                Title = $"Tingen Commander - v{Assembly.GetExecutingAssembly().GetName().Version}";
            }
            else
            {
                Title = $"Tingen Commander - v{Assembly.GetExecutingAssembly().GetName().Version} ({postfix})";
            }
        }
        private void SetRepositoryVersions(string sessionRoot)
        {
            txbxMainBranchVersion.Text = AsmxFile.GetVersion($@"{sessionRoot}\MainBranch.asmx");
            txbxDevelopmentBranchVersion.Text = AsmxFile.GetVersion($@"{sessionRoot}\DevelopmentBranch.asmx");
        }

        private void SetUatInformation()
        {
            var uatService = SettingsFile.Import(@"T:\Remote\Current-Tingen-UAT-settings.md"); // put in config

            lblUatServiceVersion.Content = uatService.ServiceVersion;
            lblUatServiceUpdated.Content = uatService.ServiceUpdated;
            lblUatServiceMode.Content    = uatService.ServiceMode;
            lblUatTraceLogLevel.Content = uatService.TraceLogLevel;
            lblUatTraceLogLevelDelay.Content = uatService.TraceLogDelay;

            SetUatServiceModeBackground(uatService.ServiceMode);

        }

        private void SetUatServiceModeBackground(string mode)
        {
            switch (mode.ToLower())
            {
                case "enabled":
                    lblUatServiceMode.Background = System.Windows.Media.Brushes.LightGreen;
                    break;
                case "passthrough":
                    lblUatServiceMode.Background = System.Windows.Media.Brushes.Yellow;
                    break;
                case "disabled":
                    lblUatServiceMode.Background = System.Windows.Media.Brushes.Salmon;
                    break;
                default:
                    lblUatServiceMode.Background = System.Windows.Media.Brushes.LightGray;
                    break;
            }


        }
    }
}