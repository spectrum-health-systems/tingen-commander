// ███ █ ██  █  ██   ███ ██  █
//  █  █ █ █ █ █  ██ ██  █ █ █
//  █  █ █  ██  ███  ███ █  ██
//
//  ██  ██  ██ ██ ██ ██  █  ██  █ ███  ███ ███
// █   █  █ █ █ █ █ █ █ ███ █ █ █ █  █ ██  ███
//  ██  ██  █   █ █   █ █ █ █  ██ ███  ███ █  █

// u250319_code
// u250319_documentation

namespace TingenCommander.Framework
{
    internal static partial class WorkstationMode
    {
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
        internal static List<string> Required(string root)
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
        internal static Dictionary<string, string> Renamed(string root)
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
        internal static List<string> Removed(string root)
        {
            return
            [
                $@"{root}/ToRemove"
            ];
        }
    }
}