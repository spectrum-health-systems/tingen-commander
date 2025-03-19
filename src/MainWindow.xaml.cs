// ████████╗██╗███╗   ██╗ ██████╗ ███████╗███╗   ██╗
// ╚══██╔══╝██║████╗  ██║██╔════╝ ██╔════╝████╗  ██║
//    ██║   ██║██╔██╗ ██║██║  ███╗█████╗  ██╔██╗ ██║
//    ██║   ██║██║╚██╗██║██║   ██║██╔══╝  ██║╚██╗██║
//    ██║   ██║██║ ╚████║╚██████╔╝███████╗██║ ╚████║
//    ╚═╝   ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝
//  ██████╗ ██████╗ ███╗   ███╗███╗   ███╗ █████╗ ███╗   ██╗██████╗ ███████╗██████╗
// ██╔════╝██╔═══██╗████╗ ████║████╗ ████║██╔══██╗████╗  ██║██╔══██╗██╔════╝██╔══██╗
// ██║     ██║   ██║██╔████╔██║██╔████╔██║███████║██╔██╗ ██║██║  ██║█████╗  ██████╔╝
// ██║     ██║   ██║██║╚██╔╝██║██║╚██╔╝██║██╔══██║██║╚██╗██║██║  ██║██╔══╝  ██╔══██╗
// ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║ ╚═╝ ██║██║  ██║██║ ╚████║██████╔╝███████╗██║  ██║
//  ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝ ╚══════╝╚═╝  ╚═╝
//                                                        Tingen Web Service Utility
//                                                         Development Release 0.3.0
//https://github.com/APrettyCoolProgram/Tingen-Commander
//Copyright (c) A Pretty Cool Program. All rights reserved.
//Licensed under the Apache 2.0 license.

// u250319_code
// u250319_documentation

using System.Windows;
using System.Windows.Controls;

namespace TingenCommander;

/// <summary>Main entry point for Tingen Commander.</summary>
public partial class MainWindow : Window
{
    /// <summary>Initializes a new instance of the <see cref="MainWindow"/> class.</summary>
    public MainWindow()
    {
        InitializeComponent();

        var cmdrSession = new Session.CmdrSession();

        /* DEVNOTE Defined here so there is one source of truth, and we can easily pass them to the SpinUp class.
         */

        var txbxControls = new Dictionary<string,TextBox>
        {
            { "txbxMachineName", txbxMachineName },
            { "txbxMachineType", txbxMachineType },
            { "txbxHostName",    txbxHostName }
        };

        Runtime.SpinUp.Initialize(cmdrSession, txbxControls);
    }
}