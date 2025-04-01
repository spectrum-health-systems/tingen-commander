// ███ █ ██  █  ██   ███ ██  █
//  █  █ █ █ █ █  ██ ██  █ █ █
//  █  █ █  ██  ███  ███ █  ██
//
//  ██  ██  ██ ██ ██ ██  █  ██  █ ███  ███ ███
// █   █  █ █ █ █ █ █ █ ███ █ █ █ █  █ ██  ███
//  ██  ██  █   █ █   █ █ █ █  ██ ███  ███ █  █

// u250401_code
// u250401_documentation

using System.IO;
using System.Windows.Controls;

using TingenCommander.Utility;
using TingenCommander.Utility.Du;

namespace TingenCommander.Runtime
{
    /// <summary>Logic to spin up a new instance of Tingen Commander.</summary>
    internal static class SpinUp
    {
        /// <summary>Initialize the Tingen Commander environment.</summary>
        /// <param name="cmdrSession">The Tingen Commander session object.</param>
        /// <param name="txbxControls">A dictionary containing any TextBox controls that will be modified.</param>
        internal static void Initialize(Session.CmdrSession cmdrSession, Dictionary<string, TextBox> txbxControls)
        {
            var cmdrRootPath = Framework.CmdrRootPath.Load(cmdrSession.CmdrRootPathFile);
            var tngnHostName = File.ReadAllText(cmdrSession.TngnHostNameFile);


            var machineType = EnvironmentDetail.GetMachineType(tngnHostName);

            UpdateUserInterface(txbxControls, machineType, tngnHostName);

            switch (EnvironmentDetail.GetMachineType(cmdrSession.TngnHostNameFile))
            {
                case "server":
                    HostMode(cmdrRootPath);
                    break;

                default:
                    WorkstationMode(cmdrRootPath);
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

        /// <summary>Verify, rename, and remove directories when in Host Mode.</summary>
        /// <param name="rootPath">The Tingen Commander root path</param>
        /// <remarks>
        /// </remarks>
        internal static void HostMode(string rootPath)
        {
            WithDirectory.Verify(Framework.Host.cat_lst_RequiredDirectories(rootPath));
            WithDirectory.Rename(Framework.Host.cat_lst_RenamedDirectories(rootPath));
            WithDirectory.Remove(Framework.Host.cat_lst_RemovedDirectories(rootPath));
        }

        /// <summary>Verify, rename, and remove directories when in Workstation Mode.</summary>
        /// <param name="rootPath">The Tingen Commander root path</param>
        /// <remarks>
        /// </remarks>
        internal static void WorkstationMode(string rootPath)
        {
            WithDirectory.Verify(Framework.WorkstationMode.cat_RequiredDirectories(rootPath));
            WithDirectory.Rename(Framework.WorkstationMode.cat_RenamedDirectories(rootPath));
            WithDirectory.Remove(Framework.WorkstationMode.cat_RemovedDirectories(rootPath));
        }
    }
}