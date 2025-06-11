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
using System.Windows;

namespace TingenCommander.Framework
{
    /// <summary>Logic related to the Tingen Commander frameworks when in Workstation mode.</summary>
    /// <remarks>
    ///   <para>
    ///     This class spans multiple partial classes:
    ///     <list type="bullet">
    ///       <item>
    ///         <term>Workstation.cs</term>
    ///         <description>Class logic</description>
    ///       </item>
    ///       <item>
    ///         <term>Workstation.Catalog.cs</term>
    ///         <description>Preset data</description>
    ///       </item>
    ///     </list>
    ///   </para>
    /// </remarks>
    internal static partial class Workstation
    {
        /// <summary>Load the Tingen Commander root path from the cmdr.rootpath file</summary>
        /// <remarks>
        ///   <para>
        ///     The location of the Tingen Commander root path is stored in the <c>AppData/Runtime/cmdr.rootpath</c> file.<br/>
        ///     <br/>
        ///     If the file does exist, the path will be verified.<br/>
        ///     <br/>
        ///     If the file does not exist, we will create it for the user, using the default values.<br/>
        ///   </para>
        /// </remarks>
        /// <returns>The Tingen Commander root path.</returns>
        internal static string LoadRootPath(string pathFile)
        {
            if (File.Exists(pathFile))
            {
                return VerifyRootPath(pathFile);
            }
            else
            {
                MissingRootPathFile(pathFile);

                /* #DEVNOTE#
                 * If the file doesn't exist, we will exit the application further down the line,
                 * and this return statement should never be reached.
                 */
                return "_exit_";
            }
        }

        /// <summary>Get the Tingen Commander root path from the file.</summary>
        /// <param name="pathFile">The file containing the root path for Tingen Commander.</param>
        /// <returns>The Tingen Commander root path.</returns>
        internal static string VerifyRootPath(string pathFile)
        {
            var rootPath = File.ReadAllText(pathFile);

            if (!Directory.Exists(rootPath))
            {
                CreateRootPath(rootPath);
            }

            /* #DEVNOTE#
             * If the defined root path doesn't exist, and the user choose not to create it, we will exit the
             * application elsewhere, and this return statement should never be reached.
             */
            return rootPath;
        }

        /// <summary>Let the user know the Tingen Commander root directory is invalid, and give the option to create it.</summary>
        /// <param name="path">The Tingen Commander root path.</param>
        internal static void CreateRootPath(string path)
        {
            var message = cat_PathNotFound(path)["Message"];
            var caption = cat_PathNotFound(path)["Caption"];

            MessageBoxResult createRootPath = MessageBox.Show(message, caption, MessageBoxButton.OKCancel);

            if (createRootPath == MessageBoxResult.OK)
            {
                Directory.CreateDirectory(path);
            }
            else
            {
                Environment.Exit(1);
            }
        }

        /// <summary>Let the user know the file that defines the Tingen Commander root directory cannot be found.</summary>
        /// <remarks>
        ///   <para>
        ///     Since Tingen Commander requires the root path file to function, we will create it for the user, using<br/>
        ///     the default values.
        ///   </para>
        /// </remarks>
        internal static void MissingRootPathFile(string pathFile)
        {
            var message = cat_PathFileNotFound(pathFile)["Message"];
            var caption = cat_PathFileNotFound(pathFile)["Caption"];

            MessageBox.Show(message, caption, MessageBoxButton.OK);

            CreateRootPathFile(pathFile);

            Environment.Exit(1);
        }

        /// <summary>Let the user know the file that defines the Tingen Commander root directory cannot be found.</summary>
        internal static void CreateRootPathFile(string pathFile)
        {
            File.WriteAllText(pathFile, "C:\\TingenWebService_Data");

            if (File.Exists(pathFile))
            {
                var message = cat_PathFileCreateError()["Message"];
                var caption = cat_PathFileCreateError()["Caption"];

                MessageBox.Show(message, caption, MessageBoxButton.OK);
            }
            else
            {
                var message = cat_PathFileCreateError()["Message"];
                var caption = cat_PathFileCreateError()["Caption"];

                MessageBox.Show(message, caption, MessageBoxButton.OK);
            }
        }

    }
}