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
    internal static partial class Host
    {
        /// <summary>Let the user know the file that defines the Tingen Web Service host name cannot be found.</summary>
        /// <returns>A message letting the user know the file that defines the Tingen Web Service host name cannot be found.</returns>
        public static string Msg_HostNameFileMissing() =>
            $"The file that defines the Tingen Web Service host name cannot be found.{Environment.NewLine}" +
            Environment.NewLine +
            $"Please verify the \"AppData\\Runtime\\tngncmdr.hostname\" file exists and contains a valid host name.";
    }
}