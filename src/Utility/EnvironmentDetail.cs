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

namespace TingenCommander.Utility
{
    /// <summary>Logic related to the Tingen Commander environment.</summary>
    /// <remarks>
    ///   <para>
    ///     This class spans multiple partial classes:
    ///     <list type="bullet">
    ///       <item>
    ///         <term>EnvironmentalDetail.cs</term>
    ///         <description>Class logic</description>
    ///       </item>
    ///       <item>
    ///         <term>EnvironmentalDetail.Catalog.cs</term>
    ///         <description>Preset data</description>
    ///       </item>
    ///     </list>
    ///   </para>
    /// </remarks>
    public static partial class EnvironmentDetail
    {
        /// <summary>Get the type of machine that Tingen Commander will run on.</summary>
        /// <remarks>
        ///   <para>
        ///     There are two types of machines that Tingen Commander can run on:
        ///     <list type="bullet">
        ///         <item>
        ///            <term>Workstation</term>
        ///            <description>A standard workstation that is used for daily stuff.</description>
        ///         </item>
        ///         <item>
        ///            <term>Server</term>
        ///            <description>A web server that hosts the Tingen Web Service.</description>
        ///         </item>
        ///     </list>
        ///   </para>
        ///   <para>
        ///     Different directories are created depending on the type of machine that Tingen Commander is running on.
        ///   </para>
        ///   <para>
        ///     The Tingen Web Service host name is stored in a file called <c>tngn.hostname</c> in the <c>AppData/Runtime</c> directory.<br/>
        ///     <br/>
        ///     Even when running on a workstation, the Tingen Web Service host name is required for some functionality.<br/>
        ///   </para>
        /// </remarks>
        /// <returns>The machine type.</returns>
        internal static string GetMachineType(string hostName)
        {
            File.WriteAllText("test.txt", hostName);

            return (Environment.MachineName == hostName)
                   ? "server"
                   : "workstation";
        }
    }
}