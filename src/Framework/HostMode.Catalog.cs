// ███ █ ██  █  ██   ███ ██  █
//  █  █ █ █ █ █  ██ ██  █ █ █
//  █  █ █  ██  ███  ███ █  ██
//
//  ██  ██  ██ ██ ██ ██  █  ██  █ ███  ███ ███
// █   █  █ █ █ █ █ █ █ ███ █ █ █ █  █ ██  ███
//  ██  ██  █   █ █   █ █ █ █  ██ ███  ███ █  █

// u250325_code
// u250325_documentation

namespace TingenCommander.Framework
{
    internal static partial class TngnHost
    {
        #region MESSAGEBOX

        /* MessageBox catalog information.
         */
        //public static string cat_PathIsInvalidCaption =>
        //    "Path is invalid!";

        //public static string cat_PathIsInvalidMessage(string rootPath) =>
        //    $"The Tingen Commander root directory defined in \"AppData\\Runtime\\tngncmdr.root\" cannot be found.{Environment.NewLine}" +
        //    Environment.NewLine +
        //    $"Would you like to create this directory now?{Environment.NewLine}" +
        //    Environment.NewLine +
        //    $"Click \"OK\" to create \"{rootPath}\"{Environment.NewLine}" +
        //    $"Click \"Cancel\" to exit Tingen Commander.";

        public static string cat_MissingFileCaption =>
            " Missing file: tngn.hostname";

        public static string cat_MissingFileMessage =>
            $"The file that defines the Tingen Web Service host name cannot be found.{Environment.NewLine}" +
            Environment.NewLine +
            "Since this file is required by Tingen Commander, it will be created for you now.";

        public static string cat_CreatedFileCaption =>
            "Created tngn.hostname file";

        public static string cat_CreatedFileMessage =>
            $"The cmdr.rootPath file has been created with the following default value:{Environment.NewLine}" +
            Environment.NewLine +
            $"  HOSTNAME{Environment.NewLine}" +
            Environment.NewLine +
            "Please re-launch Tingen Commander.";

        public static string cat_CreateFileErrorCaption =>
            "Error creating tngn.hostname file";

        public static string cat_CreateFileErrorMessage =>
            $"The tngn.hostname file could not be created.{Environment.NewLine}" +
            Environment.NewLine +
            "Try creating the file manually, then re-launching Tingen Commander.";

        #endregion MESSAGEBOX



























        /// <summary>Let the user know the file that defines the Tingen Web Service host name cannot be found.</summary>
        /// <returns>A message letting the user know the file that defines the Tingen Web Service host name cannot be found.</returns>
        public static string cat_msg_HostNameFileMissing() =>
            $"The file that defines the Tingen Web Service host name cannot be found.{Environment.NewLine}" +
            Environment.NewLine +
            $"Please verify the \"AppData\\Runtime\\tngncmdr.hostname\" file exists and contains a valid host name.";


        /// <summary>Returns a list of required server directories.</summary>
        /// <remarks>
        ///   <para>
        ///     This is a list of required server directories for the following:
        ///     <list type="bullet">
        ///       <item>The Tingen Web Service (LIVE)</item>
        ///       <item>The Tingen Web Service (UAT)</item>
        ///       <item>Tingen Commander</item>
        ///     </list>
        ///   </para>
        ///   <para>
        ///     This list was last updated <b>March 11, 2025</b>.<br/>
        ///     <br/>
        ///     These directories are hard coded here so there is one source of truth.<br/>
        ///     <br/>
        ///     If you need to add a server directory, please add it to the list below.<br/>
        ///     <br/>
        ///     If you need to rename an existing server directory, please add it to the Renamed() dictionary.<br/>
        ///     <br/>
        ///     If you need to remove an existing server directory, please add it to the Removed() list.<br/>
        ///   </para>
        ///   <para>
        ///     Whenever any of the directory dictionaries are modified, a new version of Tingen Commander should be released.
        ///   </para>
        /// </remarks>
        /// <returns>A list of required directories.</returns>
        internal static List<string> cat_lst_RequiredDirectories(string root)
        {
            return
            [
                $@"{root}/Archive",
                $@"{root}/Archive/Releases",
                $@"{root}/Commander",
                $@"{root}/Commander/Service",
                $@"{root}/Commander/Service/Deploy",
                $@"{root}/Commander/Service/Deploy/UAT",
                $@"{root}/Commander/Service/Deploy/UAT/Archive",
                $@"{root}/Commander/Service/Deploy/UAT/Logs",
                $@"{root}/Commander/Service/Deploy/UAT/Staging",
                $@"{root}/Commander/Service/Deploy/LIVE",
                $@"{root}/Commander/Service/Deploy/LIVE/Archive",
                $@"{root}/Commander/Service/Deploy/LIVE/Logs",
                $@"{root}/Commander/Service/Deploy/LIVE/Staging",
                $@"{root}/Commander/Logs",
                $@"{root}/LIVE",
                $@"{root}/LIVE/Config",
                $@"{root}/LIVE/Exports",
                $@"{root}/LIVE/Exports/Reports",
                $@"{root}/LIVE/Imports",
                $@"{root}/LIVE/Imports/FromAvatar",
                $@"{root}/LIVE/Imports/Templates",
                $@"{root}/LIVE/Messages",
                $@"{root}/LIVE/Messages/Alerts",
                $@"{root}/LIVE/Messages/Errors",
                $@"{root}/LIVE/Messages/Warnings",
                $@"{root}/LIVE/Sessions",
                $@"{root}/LIVE/Sessions/Archived",
                $@"{root}/LIVE/Debugging",
                $@"{root}/LIVE/Temporary",
                $@"{root}/Debugging",
                $@"{root}/Debugging/Primeval",
                $@"{root}/Public",
                $@"{root}/Public/Exports",
                $@"{root}/Public/Exports/Reports",
                $@"{root}/Public/Messages/Alerts",
                $@"{root}/Public/Messages/Errors",
                $@"{root}/Public/Messages/Warnings",
                $@"{root}/Remote",
                $@"{root}/Remote/Exports",
                $@"{root}/Remote/Exports/Reports",
                $@"{root}/Remote/Messages/Alerts",
                $@"{root}/Remote/Messages/Errors",
                $@"{root}/Remote/Messages/Warnings",
                $@"{root}/Remote/Sessions",
                $@"{root}/UAT",
                $@"{root}/UAT/Config",
                $@"{root}/UAT/Exports",
                $@"{root}/UAT/Exports/Reports",
                $@"{root}/UAT/Imports",
                $@"{root}/UAT/Imports/FromAvatar",
                $@"{root}/UAT/Imports/Templates",
                $@"{root}/UAT/Messages",
                $@"{root}/UAT/Messages/Alerts",
                $@"{root}/UAT/Messages/Errors",
                $@"{root}/UAT/Messages/Warnings",
                $@"{root}/UAT/Sessions",
                $@"{root}/UAT/Sessions/Archived",
                $@"{root}/UAT/Debugging",
                $@"{root}/UAT/Temporary",
            ];
        }

        /// <summary>Provides a list of server directories to be renamed.</summary>
        /// <remarks>
        ///   <para>
        ///     This list was last updated <b>March 11, 2025</b>.<br/>
        ///     <br/>
        ///     These directories are hard coded here so there is one source of truth.<br/>
        ///     <br/>
        ///     If you need to rename a server directory, please add it to the list below.<br/>
        ///     <br/>
        ///     If you need to add a new server directory, please add it to the Required() dictionary.<br/>
        ///     <br/>
        ///     If you need to remove an existing server directory, please add it to the Removed() list.<br/>
        ///   </para>
        ///   <para>
        ///     Whenever any of the directory dictionaries are modified, a new version of Tingen Commander should be released.
        ///   </para>
        /// </remarks>
        /// <returns>A list of new directory names.</returns>
        internal static Dictionary<string, string> cat_lst_RenamedDirectories(string root)
        {
            return new Dictionary<string, string>()
            {
                { $@"{root}/OldName", $@"{root}/NewName" }
            };
        }

        /// <summary>Returns a list of server directories to be removed.</summary>
        /// <remarks>
        ///   <para>
        ///     This list was last updated <b>March 11, 2025</b>.<br/>
        ///     <br/>
        ///     These directories are har dcoded here so there is one source of truth.<br/>
        ///     <br/>
        ///     If you need to remove a server directory, please add it to the list below.<br/>
        ///     <br/>
        ///     If you need to add a server directory, please add it to the Required() list.<br/>
        ///     <br/>
        ///     If you need to rename an existing server directory, please add it to the Renamed() dictionary.<br/>
        ///   </para>
        ///   <para>
        ///     Whenever any of the directory dictionaries are modified, a new version of Tingen Commander should be released.
        ///   </para>
        /// </remarks>
        /// <returns>A list of required directories.</returns>
        internal static List<string> cat_lst_RemovedDirectories(string root)
        {
            return
            [
                $@"{root}/ToRemove"
            ];
        }


    }
}