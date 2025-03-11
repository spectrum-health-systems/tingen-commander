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
//                                                    Framework.ServerDirectories.cs
//                                                                Server directories
// u250311_code
// u250311_documentation

using System.IO;

namespace TingenCommander.Framework
{
    /// <summary>Does stuff with directories.</summary>
    internal static class ServerDirectories
    {
        /// <summary>Verify the required directories exist, and create them if they don't.</summary>
        /// <param name="root">The Tingen Commander root directory.</param>
        internal static void VerifyRequired(string root)
        {
            foreach (var requiredDirectory in Catalog.RequiredServerDirectories(root))
            {
                if (!Directory.Exists(requiredDirectory))
                {
                    Directory.CreateDirectory(requiredDirectory);
                }
            }
        }

        /// <summary>Rename directories.</summary>
        /// <param name="root">The Tingen Commander root directory.</param>
        internal static void RenameDirectories(string root)
        {
            foreach (var originalRenamePair in Catalog.RenamedServerDirectories(root))
            {
                if (Directory.Exists(originalRenamePair.Key))
                {
                    Directory.Move(originalRenamePair.Key, originalRenamePair.Value);
                }
            }
        }

        /// <summary>Remove depreciated directories.</summary>
        /// <param name="root">The Tingen Commander root directory.</param>
        internal static void RemoveDirectories(string root)
        {
            foreach (var depreciatedDirectory in Catalog.DepreciatedServerDirectories(root))
            {
                if (Directory.Exists(depreciatedDirectory))
                {
                    Directory.Delete(depreciatedDirectory, true);
                }
            }
        }
    }
}