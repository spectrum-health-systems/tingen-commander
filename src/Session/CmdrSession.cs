// ███ █ ██  █  ██   ███ ██  █
//  █  █ █ █ █ █  ██ ██  █ █ █
//  █  █ █  ██  ███  ███ █  ██
//
//  ██  ██  ██ ██ ██ ██  █  ██  █ ███  ███ ███
// █   █  █ █ █ █ █ █ █ ███ █ █ █ █  █ ██  ███
//  ██  ██  █   █ █   █ █ █ █  ██ ███  ███ █  █

// u250325_code
// u250325_documentation

namespace TingenCommander.Session
{
    /// <summary>Session object for Tingen Commander.</summary>
    /// <remarks>
    ///   <para>
    ///     The <c>CmdrSession</c> object is used to all of the data that Tingen Commander needs to do its thing.
    ///   </para>
    /// </remarks>
    public class CmdrSession
    {
        /// <summary>The file that contains the root path of the Tingen Commander environment.</summary>
        /// <value>Default: "AppData/Runtime/cmdr.rootpath"</value>
        public string CmdrRootPathFile {get; set;}

        /// <summary>The file that contains the host name of the Tingen Web Service.</summary>
        /// <value>Default: ""AppData/Runtime/tngn.hostname""</value>
        public string TngnHostNameFile { get; set; }

        /// <summary>Create a new Tingen Commander session object.</summary>
        /// <returns>A new Tingen Commander session object.</returns>
        /// <remarks>
        ///   <para>
        ///     The <c>RootPathFile</c> and <c>HostNameFile</c> default values are set here so there is one<br/>
        ///     source of truth, and it is easier to change them if needed.
        ///   </para>
        /// </remarks>
        internal static CmdrSession New()
        {
            return new CmdrSession
            {
                CmdrRootPathFile = "AppData/Runtime/cmdr.rootpath",
                TngnHostNameFile = "AppData/Runtime/tngn.hostname"
            };
        }
    }
}