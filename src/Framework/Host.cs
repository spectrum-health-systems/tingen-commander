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
    /// <summary>Logic related to the Tingen Web Service host.</summary>
    /// <remarks>
    ///   <para>
    ///     This class spans multiple partial classes:
    ///     <list type="bullet">
    ///       <item>
    ///         <term>Host.cs</term>
    ///         <description>Class logic</description>
    ///       </item>
    ///       <item>
    ///         <term>Host.Catalog.cs</term>
    ///         <description>Preset data</description>
    ///       </item>
    ///     </list>
    ///   </para>
    /// </remarks>
    internal static partial class Host
    {
        /// <summary>Get the name of the machine that hosts the Tingen Web Service.</summary>
        /// <param name="hostNameFile">Contains the name of machine that hosts the Tingen Web Service.</param>
        /// <returns>The name of the machine that hosts the Tingen Web Service.</returns>
        internal static string GetHostName(string hostNameFile)
        {
            if (File.Exists(hostNameFile))
            {
                return File.ReadAllText(hostNameFile);
            }
            else
            {
                MessageBox.Show(Msg_HostNameFileMissing());
                System.Environment.Exit(1);

                return "_shutdown_";
            }
        }
    }
}
