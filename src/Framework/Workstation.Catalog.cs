// ███ █ ██  █  ██   ███ ██  █
//  █  █ █ █ █ █  ██ ██  █ █ █
//  █  █ █  ██  ███  ███ █  ██
//
//  ██  ██  ██ ██ ██ ██  █  ██  █ ███  ███ ███
// █   █  █ █ █ █ █ █ █ ███ █ █ █ █  █ ██  ███
//  ██  ██  █   █ █   █ █ █ █  ██ ███  ███ █  █

// u250401_code
// u250401_documentation

namespace TingenCommander.Framework
{
    internal static partial class Workstation
    {
        /* Messages
         */

        /// <summary></summary>
        /// <param name="rootPath">The Tingen Commander root path.</param>
        /// <returns></returns>
        public static Dictionary<string, string> cat_PathNotFound(string rootPath)
        {
            return new Dictionary<string, string> {
                { "Caption", "Root path is invalid!" },
                { "Message", $"The Tingen Commander root directory defined in \"AppData\\Runtime\\tngncmdr.root\" cannot be found.{Environment.NewLine}" +
                  Environment.NewLine +
                  $"Would you like to create this directory now?{Environment.NewLine}" +
                  Environment.NewLine +
                  $"Click \"OK\" to create \"{rootPath}\"{Environment.NewLine}" +
                  $"Click \"Cancel\" to exit Tingen Commander." }
            };
        }

        /// <summary></summary>
        /// <param name="rootPath">The Tingen Commander root path.</param>
        /// <returns></returns>
        public static Dictionary<string, string> cat_PathFileNotFound(string rootPath)
        {
            return new Dictionary<string, string> {
                { "Caption", "Cannot find the root path file: cmdr.rootpath" },
                { "Message", $"The file that defines the Tingen Commander root directory for cannot be found.{Environment.NewLine}" +
                  Environment.NewLine +
                  "Since this file is required by Tingen Commander, it will be created for you now." }
            };
        }

        /// <summary></summary>
        /// <param name="rootPath">The Tingen Commander root path.</param>
        /// <returns></returns>
        public static Dictionary<string, string> cat_PathFileCreateError()
        {
            return new Dictionary<string, string> {
                { "Caption", "Error creating cmdr.rootpath file" },
                { "Message", $"The cmdr.rootpath file could not be created.{Environment.NewLine}" +
                  Environment.NewLine +
                  "Try creating the file manually, then re-launching Tingen Commander." }
            };
        }

        /// <summary></summary>
        /// <param name="rootPath">The Tingen Commander root path.</param>
        /// <returns></returns>
        public static Dictionary<string, string> cat_PathFileCreated(string rootPath)
        {
            return new Dictionary<string, string> {
                { "Caption", "Created cmdr.rootpath file" },
                { "Message", $"The cmdr.rootPath file has been created with the following default value:{Environment.NewLine}" +
                  Environment.NewLine +
                  $"  {rootPath}\"{Environment.NewLine}" +
                  Environment.NewLine +
                  "Please re-launch Tingen Commander." }
            };
        }

        /* Directories
         */

        /// <summary>Returns a list of required workstation directories.</summary>
        /// <remarks>
        ///   <para>
        ///     This list was last updated <b>March 11, 2025</b>.<br/>
        ///     <br/>
        ///     These directories are hard coded here so there is one source of truth.<br/>
        ///     <br/>
        ///     If you need to add a workstation directory, please add it to the list below.<br/>
        ///     <br/>
        ///     If you need to rename an existing workstation directory, please add it to the Renamed() dictionary.<br/>
        ///     <br/>
        ///     If you need to remove an existing workstation directory, please add it to the Removed() list.<br/>
        ///   </para>
        ///   <para>
        ///     Whenever any of the directory dictionaries are modified, a new version of Tingen Commander should be released.
        ///   </para>
        /// </remarks>
        /// <returns>A list of required directories.</returns>
        internal static List<string> cat_RequiredDirectories(string root)
        {
            return
            [
                $@"{root}/Commander",
                $@"{root}/Commander/Logs"
            ];
        }

        /// <summary>Provides a list of workstation directory to be renamed.</summary>
        /// <remarks>
        ///   <para>
        ///     This list was last updated <b>March 11, 2025</b>.<br/>
        ///     <br/>
        ///     These directories are hard coded here so there is one source of truth.<br/>
        ///     <br/>
        ///     If you need to rename a workstation directory, please add it to the list below.<br/>
        ///     <br/>
        ///     If you need to add a new workstation directory, please add it to the Required() dictionary.<br/>
        ///     <br/>
        ///     If you need to remove an existing workstation directory, please add it to the Depreciated() list.<br/>
        ///   </para>
        ///   <para>
        ///     Whenever any of the directory dictionaries are modified, a new version of Tingen Commander should be released.
        ///   </para>
        /// </remarks>
        /// <returns>A list of new directory names.</returns>
        internal static Dictionary<string, string> cat_RenamedDirectories(string root)
        {
            return new Dictionary<string, string>()
            {
                { $@"{root}/OldName", $@"{root}/NewName" }
            };
        }

        /// <summary>Returns a list of workstation directories to be removed.</summary>
        /// <remarks>
        ///   <para>
        ///     This list was last updated <b>March 11, 2025</b>.<br/>
        ///     <br/>
        ///     These directories are hard coded here so there is one source of truth.<br/>
        ///     <br/>
        ///     If you need to remove a workstation directory, please add it to the list below.<br/>
        ///     <br/>
        ///     If you need to add a workstation directory, please add it to the Required() list.<br/>
        ///     <br/>
        ///     If you need to rename an existing workstation directory, please add it to the Renamed() dictionary.<br/>
        ///   </para>
        ///   <para>
        ///     Whenever any of the directory dictionaries are modified, a new version of Tingen Commander should be released.
        ///   </para>
        /// </remarks>
        /// <returns>A list of required directories.</returns>
        internal static List<string> cat_RemovedDirectories(string root)
        {
            return
            [
                $@"{root}/ToRemove"
            ];
        }
    }
}