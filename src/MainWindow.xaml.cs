// ================================================================= 0.9.0 =====
// Tingen Commander: A GUI for Tingen
// Repository: https://github.com/APrettyCoolProgram/Tingen-Commander
// Documentation: https://github.com/spectrum-health-systems/Tingen-Documentation
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// ================================================================ 241119 =====

// u241119.0901_code
// u241031_documentation

using System.IO;
using System.Net;
using System.Reflection;
using System.Windows;
using static System.Net.WebRequestMethods;

namespace TingenCommander
{
    /// <summary>Interaction logic for MainWindow.xaml</summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetupMainWindow();

            if (System.IO.File.Exists(@"C:\TingenData\Commander\TingenCommanderSettings.json"))
            {
            }
            else
            {
                TingenCommander.Session.CreateSettings();
            }

        /// <summary>Setup the main window when Tingen Commander starts.</summary>
        private void SetupMainWindow()
        {
            Title = BuildVersionInfo("Alpha");

            UpdateRepositoryVersions();
            UpdateServerVersions();

        }


        private void UpdateRepositoryVersions()
        {
            DownloadRepositoryFiles();
            txbxTingenDevelopmentMainBranchVersion.Text = GetAsmxVersion(@"C:\Tingen\Tingen_development_main.asmx");
            txbxTingenRepositoryDevelopmentBranch.Text= GetAsmxVersion(@"C:\Tingen\Tingen_development.asmx");
        }

        private void UpdateServerVersions()
        {
            lblTingenUatVersion.Content = $"Version {GetAsmxVersion(@"C:\Tingen\UAT\Tingen_development.asmx.cs")}";
            txbxTingenLiveVersion.Text = GetAsmxVersion(@"C:\Tingen\LIVE\Tingen.asmx.cs");

        }


        /// <summary>Build the Tingen Commander version information.</summary>
        /// <param name="releaseStage">The release stage (e.g., "Alpha", "Beta")</param>
        /// <remarks>
        /// If <c>releaseStage</c> is passed as an empty string (e.g., <c>""</c>), only the version number will be used.
        /// </remarks>
        /// <returns>The Tingen Commander version string.</returns>
        private string BuildVersionInfo(string releaseStage)
        {
            if (!string.IsNullOrWhiteSpace(releaseStage))
            {
                releaseStage = $"({releaseStage})";
            }

            return $"Tingen Commander - v{Assembly.GetExecutingAssembly().GetName().Version} {releaseStage}";
        }

        private void DownloadRepositoryFiles()
        {
            DownloadInternetFile("https://raw.githubusercontent.com/spectrum-health-systems/Tingen-Development/refs/heads/main/src/Tingen_development.asmx.cs", @"C:\Tingen\Tingen_development_main.asmx");
            DownloadInternetFile("https://raw.githubusercontent.com/spectrum-health-systems/Tingen-Development/refs/heads/development/src/Tingen_development.asmx.cs", @"C:\Tingen\Tingen_development.asmx");
        }

        private void DownloadInternetFile(string toDownload, string toSave)
        {
            var asmxUrl = toDownload;
            var asmxDownloadPath = toSave;

            var client = new WebClient();
            client.DownloadFile(asmxUrl, asmxDownloadPath);
        }



        private string GetAsmxVersion(string asmxFile)
        {
            string asmxVersion = "Unknown";

            if (System.IO.File.Exists(asmxFile))
            {
                using (StreamReader reader = new StreamReader(asmxFile))
                {
                    asmxVersion = reader.ReadLine() ?? "";
                }

                asmxVersion = asmxVersion.Replace("//", "");
                asmxVersion = asmxVersion.Replace("=", "");

                asmxVersion =  asmxVersion.Trim();
            }

            return asmxVersion;

        }
    }
}