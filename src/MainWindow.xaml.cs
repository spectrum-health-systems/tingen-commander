// =============================================================== 24.10.0 =====
// Tingen Commander:
// https://github.com/APrettyCoolProgram/Tingen-Commander
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// ================================================================ 241019 =====

// u2241019.0910_code
// u241019_documentation

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TingenCommander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string TingenMode { get; set; }


        public MainWindow()
        {
            InitializeComponent();

            TingenMode = "Enabled";

            SetupTingenMode(TingenMode);
        }

        private void BtnTingenMode_Click(object sender, RoutedEventArgs e)
        {
            var message = "";

            if (TingenMode == "Enabled")
            {
                message = $"YOU ARE ABOUT TO DISABLE THE TINGEN WEB SERVICE!{Environment.NewLine}" +
                          Environment.NewLine +
                          $"The Tingen web service is currently enabled.{Environment.NewLine}" +
                          Environment.NewLine +
                          $"Clicking \"Yes\" will disable Tingen entirely.{Environment.NewLine}" +
                          Environment.NewLine +
                          $"If you disable the Tingen, it will not function.{Environment.NewLine}" +
                          Environment.NewLine +
                          $"Are you sure you want to do this?{ Environment.NewLine}" +
                          Environment.NewLine +
                          $"If you are not sure, click \"No\", and Tingen will remain enabled.";
            }
            else if (TingenMode == "Disabled")
            {
                message = "Clicking \"OK\" will enable the Tingen web service. Are you sure you want to do this?";
            }
            else if (TingenMode == "Passthrough")
            {
                message = "Clicking \"OK\" will force-enable the Tingen web service. Are you sure you want to do this?";
            }
            else
            {
                message = "Clicking \"OK\" won't do anything.";
            }

            var test = MessageBox.Show(message, "IMPORTANT! PLEASE READ THIS MESSAGE!", MessageBoxButton.YesNo);

            if (test == MessageBoxResult.Yes)
            {
                TingenMode = "Enabled";
                BtnTingenMode.Content = "Enableddsdsd";
            }


        }


        private void SetupTingenMode(string tingenMode)
        {
            if (tingenMode == "Enabled")
            {
                BtnTingenMode.Content = "Enabled";
                BtnTingenMode.Background = Brushes.Green;
            }
            else if (tingenMode == "Disabled")
            {
                BtnTingenMode.Content = "Disabled";
                BtnTingenMode.Background = Brushes.Red;
            }
            else if (tingenMode == "Passthrough")
            {
                BtnTingenMode.Content = "Passthrough";
                BtnTingenMode.Background = Brushes.Orange;
            }
            else
            {
                BtnTingenMode.Content = "Unknown";
                BtnTingenMode.Background = Brushes.Gray;
            }
        }
    }
}