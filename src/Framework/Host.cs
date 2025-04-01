// ███ █ ██  █  ██   ███ ██  █
//  █  █ █ █ █ █  ██ ██  █ █ █
//  █  █ █  ██  ███  ███ █  ██
//
//  ██  ██  ██ ██ ██ ██  █  ██  █ ███  ███ ███
// █   █  █ █ █ █ █ █ █ ███ █ █ █ █  █ ██  ███
//  ██  ██  █   █ █   █ █ █ █  ██ ███  ███ █  █

// u250325_code
// u250325_documentation

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
        internal static string Load(string hostNameFile)
        {
            if (File.Exists(hostNameFile))
            {
                return File.ReadAllText(hostNameFile);
            }
            else
            {
                MissingHostNameFile(hostNameFile);

                /* #DEVNOTE#
                 * If the file doesn't exist, we will exit the application further down the line,
                 * and this return statement should never be reached.
                 */
                return "_exit_";
            }
        }

        /// <summary>Let the user know the file that defines the Tingen Web Service host name cannot be found.</summary>
        /// <remarks>
        ///   <para>
        ///     Since Tingen Commander requires the root path file to function, we will create it for the user, using<br/>
        ///     the default values.
        ///   </para>
        /// </remarks>
        internal static void MissingHostNameFile(string hostNameFile)
        {
            MessageBox.Show(cat_MissingFileMessage, cat_MissingFileCaption, MessageBoxButton.OK);

            CreateHostNameFile(hostNameFile);

            Environment.Exit(1);
        }

        /// <summary>Let the user know the file that defines the Tingen Commander root directory cannot be found.</summary>
        internal static void CreateHostNameFile(string hostNameFile)
        {
            File.WriteAllText(hostNameFile, "C:\\TingenWebService_Data");

            if (File.Exists(hostNameFile))
            {
                MessageBox.Show(cat_CreatedFileMessage, cat_CreatedFileCaption, MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show(cat_CreateFileErrorMessage, cat_CreateFileErrorCaption, MessageBoxButton.OK);
            }
        }

    }
}