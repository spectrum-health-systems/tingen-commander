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
using System.Reflection;
using System.Windows;

namespace TingenCommander
{
    /// <summary>Interaction logic for MainWindow.xaml</summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetupMainWindow();
        }

        /// <summary>Setup the main window when Tingen Commander starts.</summary>
        private void SetupMainWindow()
        {
            Title = BuildVersionInfo("Alpha");

            txbxTingenUatVersion.Text = GetUatVersion();
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

        private string GetUatVersion()
        {
            var fileContents = File.ReadAllLines(@"C:\Tingen\UAT\Tingen_development.asmx.cs");

            var versionLine = fileContents[0];

            var versionNumber = versionLine.Replace("=", "");

            var versionNumber2 = versionNumber.Trim();

            return versionNumber2;
        }
    }
}