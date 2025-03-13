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

namespace TingenCommander.Framework
{
    internal static partial class ServerMode
    {

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
        internal static List<string> Required(string root)
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
        internal static Dictionary<string, string> Renamed(string root)
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
        internal static List<string> Removed(string root)
        {
            return
            [
                $@"{root}/ToRemove"
            ];
        }
    }
}
