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
//                                                        Development Release 25.4.0
// https://github.com/APrettyCoolProgram/Tingen-Commander
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.

// u250325_code
// u250325_documentation

using System.Windows;
using System.Windows.Controls;

namespace TingenCommander;

/// <summary>Main entry point for Tingen Commander.</summary>
public partial class MainWindow : Window
{
    /// <summary>Initializes a new instance of the <see cref="MainWindow"/> class.</summary>
    /// <remarks>
    ///   <para>
    ///     The <c>cmdrSession</c> object is initialized with some basic data, but will end up containing all of<br/>
    ///     data that Tingen Commander needs to function.
    ///   </para>
    ///   <para>
    ///     The <c>controlsToModify</c> object contains the controls that we'll need to modify and we'll define
    ///     them here so:
    ///     <list type="bullet">
    ///       <item>They are set one time, in one place, to avoid spelling mistakes and making them easier to modify</item>
    ///       <item>They are easier to pass to SpinUp.Initialize()</item>
    ///     </list>
    ///   </para>
    /// </remarks>
    public MainWindow()
    {
        InitializeComponent();

        var cmdrSession = Session.CmdrSession.New();

        var controlsToModify = new Dictionary<string,TextBox>
        {
            { "txbxMachineName", txbxMachineName },
            { "txbxMachineType", txbxMachineType },
            { "txbxHostName",    txbxHostName }
        };

        Runtime.SpinUp.Initialize(cmdrSession, controlsToModify);
    }
}