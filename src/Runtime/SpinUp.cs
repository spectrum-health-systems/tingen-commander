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
// u250313_code
// u250313_documentation

using TingenCommander.Utility;

namespace TingenCommander.Runtime
{
    /// <summary>Logic to spin up a new instance of Tingen Commander.</summary>
    internal static class SpinUp
    {
        internal static void Initialize(string rootPathFile, string hostNameFile)
        {
            var cmdrRootPath = Framework.RootPath.GetPath(rootPathFile);


                switch (EnvironmentDetail.GetMachineType(hostNameFile))
                {
                    case "server":
                        Server(cmdrRootPath);
                        break;

                    default:
                        Workstation(cmdrRootPath);
                        break;
                }
            
        }

        internal static void Server(string rootPath)
        {
            Framework.Directories.Verify(Framework.ServerMode.Required(rootPath));
            Framework.Directories.Rename(Framework.ServerMode.Renamed(rootPath));
            Framework.Directories.Remove(Framework.ServerMode.Removed(rootPath));
        }

        internal static void Workstation(string rootPath)
        {
            Framework.Directories.Verify(Framework.WorkstationMode.Required(rootPath));
            Framework.Directories.Rename(Framework.WorkstationMode.Renamed(rootPath));
            Framework.Directories.Remove(Framework.WorkstationMode.Removed(rootPath));
        }
    }
}
