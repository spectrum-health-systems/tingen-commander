// ████████╗██╗███╗   ██╗ ██████╗ ███████╗███╗   ██╗
// ╚══██╔══╝██║████╗  ██║██╔════╝ ██╔════╝████╗  ██║
//    ██║   ██║██╔██╗ ██║██║  ███╗█████╗  ██╔██╗ ██║
//    ██║   ██║██║ ╚████║╚██████╔╝███████╗██║ ╚████║
//    ╚═╝   ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝
//  ██████╗ ██████╗ ███╗   ███╗███╗   ███╗ █████╗ ███╗   ██╗██████╗ ███████╗██████╗
// ██╔════╝██╔═══██╗████╗ ████║████╗ ████║██╔══██╗████╗  ██║██╔══██╗██╔════╝██╔══██╗
// ██║     ██║   ██║██╔████╔██║██╔████╔██║███████║██╔██╗ ██║██║  ██║█████╗  ██████╔╝
// ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║ ╚═╝ ██║██║  ██║██║ ╚████║██████╔╝███████╗██║  ██║
//  ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝ ╚══════╝╚═╝  ╚═╝
//                                                                 Runtime.Spinm.cs
//                                      Startup/shutdown logic for Tingen Commander
// u250311_code
// u250311_documentation

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TingenCommander.Runtime
{
    internal static class Spin
    {
        internal static void Start(string rootPathFile, string serverNameFile)
        {
            if (GetMachineType(serverNameFile) == "server")
            {
                ServerUp(GetTngnCmdrRoot(rootPathFile));
            }
            else
            {
                WorkstationUp(GetTngnCmdrRoot(rootPathFile));
            }

        }

        internal static void ServerUp(string rootPath)
        {
            Framework.ServerDirectories.VerifyRequired(rootPath);
            Framework.ServerDirectories.RenameDirectories(rootPath);
            Framework.ServerDirectories.RemoveDirectories(rootPath);

        }

        internal static void WorkstationUp(string rootPath)
        {
            Framework.WorkstationDirectories.VerifyRequired(rootPath);
            Framework.WorkstationDirectories.RenameDirectories(rootPath);
            Framework.WorkstationDirectories.RemoveDirectories(rootPath);
        }

        /// <summary>Get the root directory for Tingen Commander.</summary>
        /// <remarks>
        ///   <para>
        ///     The Tingen Commander root directory is stored in a file called <c>tngncmdr.root</c> in the <c>AppData/Runtime</c> directory.
        ///   </para>
        /// </remarks>
        /// <returns>The root directory for Tingen Commander.</returns>
        internal static string GetTngnCmdrRoot(string rootPathFile)
        {
            if (File.Exists(rootPathFile))
            {
                return File.ReadAllText(rootPathFile);
            }
            else
            {
                MessageBox.Show(MsgCmdrRootError());
                Application.Current.Shutdown();

                return "";
            }
        }

        /// <summary>Get they type of machine that Tingen Commander will run on.</summary>
        /// <remarks>
        ///   <para>
        ///     There are two types of machines that Tingen Commander can run on:
        ///     <list type="bullet">
        ///         <item>
        ///            <term>Workstation</term>
        ///            <description>A standard workstation that is used for daily stuff.</description>
        ///         </item>
        ///            <term>Web server</term>
        ///            <description>A web server that hosts the Tingen Web Service.</description>
        ///         </item>
        ///     </list>
        ///   </para>
        ///   <para>
        ///     Different directories are created depending on the type of machine that Tingen Commander is running on.
        ///   </para>
        /// </remarks>
        /// <returns>The root directory for Tingen Commander.</returns>
        internal static string GetMachineType(string serverNameFile)
        {
            var serverName = "";


            if (File.Exists(serverNameFile))
            {
                serverName = File.ReadAllText(serverNameFile);

                return (Environment.MachineName == serverName)
                    ? "server"
                    : "workstation";
            }
            else
            {
                MessageBox.Show(MsgServerNameError());
                Application.Current.Shutdown();

                return "";
            }
        }

        /// <summary>The message that is displayed when the root directory file is not found.</summary>
        /// <returns>A message to display to the user.</returns>
        internal static string MsgCmdrRootError()
        {
            return $"The root directory for Tingen Commander has not been set.{Environment.NewLine}" +
                   Environment.NewLine +
                   $"Please make sure the \"AppData\\Runtime\\tngncmdr.root\" file exists and contains the root directory for Tingen Commander.";
        }

        /// <summary>The message that is displayed when the root directory file is not found.</summary>
        /// <returns>A message to display to the user.</returns>
        internal static string MsgServerNameError()
        {
            return $"The Tingen Web Service server name has not been set.{Environment.NewLine}" +
                   Environment.NewLine +
                   $"Please make sure the \"AppData\\Runtime\\tngncmdr.servername\" file exists and contains the server name that hosts the Tingen Web Service.";
        }
    }
}
