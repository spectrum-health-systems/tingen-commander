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
//                                                                 Framework.Catalog
//                                             Pre-created data for Tingen Commander
// u250311_code
// u250311_documentation

namespace TingenCommander.Framework
{
    internal static class Catalog
    {

        /// <summary>Returns a list of required directories.</summary>
        /// <remarks>
        ///   <para>
        ///     This is a list of required directories for the following:
        ///     <list type="bullet">
        ///       <item>The Tingen Web Service (LIVE)</item>
        ///       <item>The Tingen Web Service (UAT)</item>  
        ///       <item>Tingen Commander</item>
        ///     </list>
        ///   </para>
        ///   <para>
        ///     This list was last updated <b>March 11, 2025</b>.<br/>
        ///     <br/>
        ///     These directories are hardcoded here so there is one source of truth.<br/>
        ///     <br/>
        ///     If you need to add a directory, please add it to the list below.<br/>
        ///     <br/>
        ///     If you need to rename an existing directory, please add it to the RenamedDirectories() dictionary.<br/>
        ///     <br/>
        ///     If you need to remove an existing directory, please add it to the DepreciatedDirectories() list.<br/>
        ///   </para>
        ///   <para>
        ///     Whenever any of the directory dictionaries are modified, a new version of Tingen Commander should be released.
        ///   </para>
        /// </remarks>
        /// <returns>A list of required directories.</returns>
        internal static List<string> RequiredDirectories(string root)
        {
            return
            [
                $@"{root}/Administrator",
                $@"{root}/Archive",
                $@"{root}/Archive/Logs",
                $@"{root}/Archive/Releases",
                $@"{root}/Cache",
                $@"{root}/Commander",
                $@"{root}/Lieutenant",
                $@"{root}/LIVE",
                $@"{root}/LIVE/Admin",
                $@"{root}/LIVE/Archive",
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
                $@"{root}/LIVE/Security",
                $@"{root}/LIVE/Sessions",
                $@"{root}/LIVE/Support",
                $@"{root}/LIVE/Support/Admin",
                $@"{root}/LIVE/Support/Archive",
                $@"{root}/LIVE/Support/Debugging",
                $@"{root}/LIVE/Support/Logs",
                $@"{root}/LIVE/Temporary",
                $@"{root}/Primeval",
                $@"{root}/Public",
                $@"{root}/Public/Alerts",
                $@"{root}/Public/Errors",
                $@"{root}/Public/Exports",
                $@"{root}/Public/Reports",
                $@"{root}/Public/Warnings",
                $@"{root}/Remote",
                $@"{root}/Remote/Alerts",
                $@"{root}/Remote/Errors",
                $@"{root}/Remote/Exports",
                $@"{root}/Remote/Reports",
                $@"{root}/Remote/Sessions",
                $@"{root}/Remote/Warnings",
                $@"{root}/UAT"
            ];
        }

        /// <summary>Provides a list of new directory names.</summary>
        /// <remarks>
        ///   <para>
        ///     This list was last updated <b>March 11, 2025</b>.<br/>
        ///     <br/>
        ///     These directories are hardcoded here so there is one source of truth.<br/>
        ///     <br/>
        ///     If you need to rename a directory, please add it to the list below.<br/>
        ///     <br/>
        ///     If you need to add a new directory, please add it to the RequiredDirectories() dictionary.<br/>
        ///     <br/>
        ///     If you need to remove an existing directory, please add it to the DepreciatedDirectories() list.<br/>
        ///   </para>
        ///   <para>
        ///     Whenever any of the directory dictionaries are modified, a new version of Tingen Commander should be released.
        ///   </para>
        /// </remarks>
        /// <returns>A list of new directory names.</returns>
        internal static Dictionary<string,string> RenamedDirectories(string root)
        {
            return new Dictionary<string, string>()
            {
                { $@"{root}/Backup", $@"{root}/Backups" }
            };
        }

        /// <summary>Returns a list of depreciated directories to be removed.</summary>
        /// <remarks>
        ///   <para>
        ///     This list was last updated <b>March 11, 2025</b>.<br/>
        ///     <br/>
        ///     These directories are hardcoded here so there is one source of truth.<br/>
        ///     <br/>
        ///     If you need to remove a directory, please add it to the list below.<br/>
        ///     <br/>
        ///     If you need to add a directory, please add it to the list below.<br/>
        ///     <br/>
        ///     If you need to rename an existing directory, please add it to the RenamedDirectories() dictionary.<br/>
        ///   </para>
        ///   <para>
        ///     Whenever any of the directory dictionaries are modified, a new version of Tingen Commander should be released.
        ///   </para>
        /// </remarks>
        /// <returns>A list of required directories.</returns>
        internal static List<string> DepreciatedDirectories(string root)
        {
            return
            [
                $@"{root}/Backup"
            ];
        }
    }
}