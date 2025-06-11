// ███ █ ██  █  ██   ███ ██  █
//  █  █ █ █ █ █  ██ ██  █ █ █
//  █  █ █  ██  ███  ███ █  ██
//
//  ██  ██  ██ ██ ██ ██  █  ██  █ ███  ███ ███
// █   █  █ █ █ █ █ █ █ ███ █ █ █ █  █ ██  ███
//  ██  ██  █   █ █   █ █ █ █  ██ ███  ███ █  █

// u250327_code
// u250327_documentation

using System.IO;
using System.Windows;

namespace TingenCommander.Framework
{
    /// <summary>Logic for the Tingen Commander root path.</summary>
    /// <remarks>
    ///   <para>
    ///     This class spans multiple partial classes:
    ///     <list type="bullet">
    ///       <item>
    ///         <term>CmdrRootPath.cs</term>
    ///         <description>Tingen Commander root path logic.</description>
    ///       </item>
    ///       <item>
    ///         <term>CmdrRootPath.Catalog.cs</term>
    ///         <description>Tingen Commander root path preset data</description>
    ///       </item>
    ///     </list>
    ///   </para>
    ///   <para>
    ///     All Tingen Commander data is stored in the root path directory.<br/>
    ///     <br/>
    ///     There are two main variables that you will see here:
    ///     <list type="bullet">
    ///       <item>
    ///         <term>rootPathFile</term>
    ///         <description>The file that contains the location of the root path (e.g., "<c>AppData/Runtime/cmdr.rootpath</c>"</description>
    ///       </item>
    ///       <item>
    ///         <term>rootPath</term>
    ///         <description>The root path (e.g., "<c>C:\TingenWebService_Data\Commander</c>"</description>
    ///       </item>
    ///     </list>
    ///   </para>
    /// </remarks>
    internal static partial class CmdrRootPath
    {
        ///// <summary>Load the Tingen Commander root path from the cmdr.rootpath file</summary>
        ///// <remarks>
        /////   <para>
        /////     The location of the Tingen Commander root path is stored in the <c>AppData/Runtime/cmdr.rootpath</c> file.<br/>
        /////     <br/>
        /////     If the file does exist, the path will be verified.<br/>
        /////     <br/>
        /////     If the file does not exist, we will create it for the user, using the default values.<br/>
        /////   </para>
        ///// </remarks>
        ///// <returns>The Tingen Commander root path.</returns>
        //internal static string Load(string cmdrRootPathFile)
        //{
        //    if (File.Exists(cmdrRootPathFile))
        //    {
        //        return Verify(cmdrRootPathFile);
        //    }
        //    else
        //    {
        //        MissingFile(cmdrRootPathFile);

        //        /* #DEVNOTE#
        //         * If the file doesn't exist, we will exit the application further down the line,
        //         * and this return statement should never be reached.
        //         */
        //        return "_exit_";
        //    }
        //}

        ///// <summary>Get the Tingen Commander root path from the file.</summary>
        ///// <param name="cmdrRootPathFile">The file containing the root path for Tingen Commander.</param>
        ///// <returns>The Tingen Commander root path.</returns>
        //internal static string Verify(string cmdrRootPathFile)
        //{
        //    var rootPath = File.ReadAllText(cmdrRootPathFile);

        //    if (!Directory.Exists(rootPath))
        //    {
        //        Create(rootPath);
        //    }

        //    /* #DEVNOTE#
        //     * If the defined root path doesn't exist, and the user choose not to create it, we will exit the
        //     * application elsewhere, and this return statement should never be reached.
        //     */
        //    return rootPath;
        //}

        ///// <summary>Let the user know the Tingen Commander root directory is invalid, and give the option to create it.</summary>
        ///// <param name="cmdrRootPath">The Tingen Commander root path.</param>
        //internal static void Create(string cmdrRootPath)
        //{
        //    MessageBoxResult createRootPath = MessageBox.Show(cat_PathIsInvalidMessage(cmdrRootPath), cat_PathIsInvalidCaption, MessageBoxButton.OKCancel);

        //    if (createRootPath == MessageBoxResult.OK)
        //    {
        //        Directory.CreateDirectory(cmdrRootPath);
        //    }
        //    else
        //    {
        //        Environment.Exit(1);
        //    }
        //}

        ///// <summary>Let the user know the file that defines the Tingen Commander root directory cannot be found.</summary>
        ///// <remarks>
        /////   <para>
        /////     Since Tingen Commander requires the root path file to function, we will create it for the user, using<br/>
        /////     the default values.
        /////   </para>
        ///// </remarks>
        //internal static void MissingFile(string cmdrRootPathFile)
        //{
        //    MessageBox.Show(cat_MissingFileMessage, cat_MissingFileCaption, MessageBoxButton.OK);

        //    CreateFile(cmdrRootPathFile);

        //    Environment.Exit(1);
        //}


        ///// <summary>Let the user know the file that defines the Tingen Commander root directory cannot be found.</summary>
        //internal static void CreateFile(string cmdrRootPathFile)
        //{
        //    File.WriteAllText(cmdrRootPathFile, "C:\\TingenWebService_Data");

        //    if (File.Exists(cmdrRootPathFile))
        //    {
        //        MessageBox.Show(cat_CreatedFileMessage, cat_CreatedFileCaption, MessageBoxButton.OK);
        //    }
        //    else
        //    {
        //        MessageBox.Show(cat_CreateFileErrorMessage, cat_CreateFileErrorCaption, MessageBoxButton.OK);
        //    }
        //}
    }
}