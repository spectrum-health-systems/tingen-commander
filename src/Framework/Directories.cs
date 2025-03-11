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
//                                                                 Framework.Catalog
//                                             Pre-created data for Tingen Commander
// u250311_code
// u250311_documentation

using System.IO;
using System.Windows;

namespace TingenCommander.Framework
{
    internal static class Directories
    {
        internal static void VerifyRequired()
        {
            foreach (var requiredDirectory in Catalog.RequiredDirectories(GetTngnCmdrRoot()))
            {
                if (!Directory.Exists(requiredDirectory))
                {
                    Directory.CreateDirectory(requiredDirectory);
                }
            }
        }

        internal static void RenameDirectories()
        {
            foreach (var originalRenamePair in Catalog.RenamedDirectories(GetTngnCmdrRoot()))
            {
                if (Directory.Exists(originalRenamePair.Key))
                {
                    Directory.Move(originalRenamePair.Key, originalRenamePair.Value);
                }
            }
        }

        internal static void RemoveDirectories()
        {
            foreach (var depreciatedDirectory in Catalog.DepreciatedDirectories(GetTngnCmdrRoot()))
            {
                if (Directory.Exists(depreciatedDirectory))
                {
                    Directory.Delete(depreciatedDirectory, true);
                }
            }
        }



        internal static string GetTngnCmdrRoot()
        {
            if (File.Exists(@"./AppData/Runtime/tngncmdr.root"))
            {
                return File.ReadAllText("./AppData/Runtime/tngncmdr.root");
            }
            else
            {
                MessageBox.Show("The root directory for Tingen Commander has not been set. Please set the root directory in the settings.");
                Application.Current.Shutdown();
                return "";
            }
        }
    }
}