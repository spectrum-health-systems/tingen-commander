// ███ █ ██  █  ██   ███ ██  █
//  █  █ █ █ █ █  ██ ██  █ █ █
//  █  █ █  ██  ███  ███ █  ██
//
//  ██  ██  ██ ██ ██ ██  █  ██  █ ███  ███ ███
// █   █  █ █ █ █ █ █ █ ███ █ █ █ █  █ ██  ███
//  ██  ██  █   █ █   █ █ █ █  ██ ███  ███ █  █

// u250319_code
// u250319_documentation

using System.IO;
using System.Windows.Controls;

using TingenCommander.Utility;

namespace TingenCommander.Runtime
{
    /// <summary>Logic to spin up a new instance of Tingen Commander.</summary>
    internal static class SpinUp
    {
        /// <summary>Initialize the Tingen Commander environment.</summary>
        /// <param name="cmdrSession">The Tingen Commander session object.</param>
        /// <param name="txbxControls">A dictionary containing any TextBox controls that will be modified.</param>
        /// <remarks>
        /// <para>
        /// </para>
        /// </remarks>
        internal static void Initialize(Session.CmdrSession cmdrSession, Dictionary<string, TextBox> txbxControls)
        {
            var rootPath    = Framework.RootPath.GetPath(cmdrSession.RootPathFile);
            var hostName    = File.ReadAllText(cmdrSession.HostNameFile);
            var machineType = EnvironmentDetail.GetMachineType(hostName);

            UpdateUserInterface(txbxControls, machineType, hostName);

            switch (EnvironmentDetail.GetMachineType(cmdrSession.HostNameFile))
            {
                case "server":
                    ServerMode(rootPath);
                    break;

                default:
                    WorkstationMode(rootPath);
                    break;
            }
        }

        /// <summary>Update user interface TextBox controls.</summary>
        /// <param name="txbxControls">A dictionary containing any TextBox controls that will be modified.</param>
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