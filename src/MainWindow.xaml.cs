// ================================================================= 0.9.0 =====
// Tingen Commander: A GUI for Tingen
// Repository: https://github.com/spectrum-health-systems/Tingen-Commander
// Documentation: https://github.com/spectrum-health-systems/Tingen-Documentation
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// ================================================================ 241217 =====

// u241217.1132_code
// u241217_documentation

using System.IO;
using System.Reflection;
using System.Windows;
using TingenLieutenant;
using TingenLieutenant.Du;

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

            Sesh cmdrSesh = Sesh.LoadConfiguration(configFilePath);

            Sesh.ResetSessionData(cmdrSesh.DataRoot);

            InitializeMainWindow(cmdrSesh);
        }

        /// <summary>Setup the main window when Tingen Commander starts.</summary>
        private void InitializeMainWindow(Sesh cmdrSesh)
        {
            Title = AppInfo.BuildVersionInfo("Alpha");

            TingenLieutenant.Repository.UpdateRepositoryVersions(cmdrSesh.DataRoot);

            txbxTingenDevelopmentMainBranchVersion.Text = TingenLieutenant.AsmxFiles.GetAsmxVersion($@"{cmdrSesh.DataRoot}\Tingen_development_main.asmx");
            txbxTingenRepositoryDevelopmentBranch.Text = TingenLieutenant.AsmxFiles.GetAsmxVersion($@"{cmdrSesh.DataRoot}\Tingen_development.asmx");
        }


        //private string GetAsmxVersion(string asmxFile)
        //{
        //    string asmxVersion = "Unknown";

        //    if (System.IO.File.Exists(asmxFile))
        //    {
        //        using (StreamReader reader = new StreamReader(asmxFile))
        //        {
        //            asmxVersion = reader.ReadLine() ?? "";
        //        }

        //        asmxVersion = asmxVersion.Replace("//", "");
        //        asmxVersion = asmxVersion.Replace("=", "");

        //        asmxVersion = asmxVersion.Trim();
        //    }

        //    return asmxVersion;

        //}
    }
}