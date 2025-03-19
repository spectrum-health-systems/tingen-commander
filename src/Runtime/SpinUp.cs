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
//
// u250317_code
// u250317_documentation

using System.IO;
using System.Windows.Controls;

using TingenCommander.Utility;

namespace TingenCommander.Runtime
{
    /// <summary>Logic to spin up a new instance of Tingen Commander.</summary>
    internal static class SpinUp
    {
        internal static void Initialize(Session.CmdrSession cmdrSession, Dictionary<string, TextBox> txbxControls)
        //internal static void Initialize(Session.CmdrSession cmdrSession, string rootPathFile, string hostNameFile, Dictionary<string, TextBox> txbxControls)
        {
            var rootPath    = Framework.RootPath.GetPath(cmdrSession.RootPath);
            var hostName    = File.ReadAllText(hostNameFile);
            var machineType = EnvironmentDetail.GetMachineType(hostName);

            UpdateUserInterface(txbxControls, machineType, hostName);

            switch (EnvironmentDetail.GetMachineType(hostNameFile))
            {
                case "server":
                    ServerMode(rootPath);
                    break;

                default:
                    WorkstationMode(rootPath);
                    break;
            }
        }

        /// <summary>
        /// Update user interface.
        /// </summary>
        /// <param name="txbxControls">The txbx controls.</param>
        /// <param name="machineType">The machine type.</param>
        /// <param name="hostName">The host name.</param>
        internal static void UpdateUserInterface(Dictionary<string, TextBox> txbxControls, string machineType, string hostName)
        {
            txbxControls["txbxMachineName"].Text = Environment.MachineName;
            txbxControls["txbxMachineType"].Text = machineType.ToUpper();
            txbxControls["txbxHostName"].Text    = hostName;
        }

        internal static void ServerMode(string rootPath)
        {
            Framework.Directories.Verify(Framework.ServerMode.Required(rootPath));
            Framework.Directories.Rename(Framework.ServerMode.Renamed(rootPath));
            Framework.Directories.Remove(Framework.ServerMode.Removed(rootPath));
        }

        internal static void WorkstationMode(string rootPath)
        {
            Framework.Directories.Verify(Framework.WorkstationMode.Required(rootPath));
            Framework.Directories.Rename(Framework.WorkstationMode.Renamed(rootPath));
            Framework.Directories.Remove(Framework.WorkstationMode.Removed(rootPath));
        }
    }
}