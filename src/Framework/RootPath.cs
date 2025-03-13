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

using System.IO;
using System.Windows;

namespace TingenCommander.Framework
{
    internal static partial class RootPath
    {
        /// <summary>Get the root directory for Tingen Commander.</summary>
        /// <remarks>
        ///   <para>
        ///     The Tingen Commander root directory is stored in a file called <c>tngncmdr.root</c> in the <c>AppData/Runtime</c> directory.
        ///   </para>
        /// </remarks>
        /// <returns>The root directory for Tingen Commander.</returns>
        internal static string GetPath(string rootPathFile)
        {
            if (File.Exists(rootPathFile))
            {
                var rootPath = File.ReadAllText(rootPathFile);

                if (Directory.Exists(rootPath))
                {
                    return rootPath;
                }
                else
                {
                    MessageBoxResult createRootPath = MessageBox.Show(Msg_CmdrRootInvalid(rootPath), "Invalid root path", MessageBoxButton.OKCancel);

                    if (createRootPath == MessageBoxResult.Cancel)
                    {
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Directory.CreateDirectory(rootPath);
                    }

                    return rootPath;
                }
            }
            else
            {
                MessageBox.Show(Msg_CmdrRootFileMissing());
                System.Environment.Exit(1);

                return "_shutdown_";
            }
        }
    }
}
