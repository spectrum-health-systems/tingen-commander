// ███ █ ██  █  ██   ███ ██  █
//  █  █ █ █ █ █  ██ ██  █ █ █
//  █  █ █  ██  ███  ███ █  ██
//
//  ██  ██  ██ ██ ██ ██  █  ██  █ ███  ███ ███
// █   █  █ █ █ █ █ █ █ ███ █ █ █ █  █ ██  ███
//  ██  ██  █   █ █   █ █ █ █  ██ ███  ███ █  █

// u250319_code
// u250319_documentation

namespace TingenCommander.Utility
{
    public static partial class EnvironmentDetail
    {


        /// <summary>Let the user know the file that defines the name of the server that hosts the Tingen Web Service cannot be found.</summary>
        /// <returns>A message letting the user know the file that defines the name of the server that hosts the Tingen Web Service cannot be found.</returns>
        public static string Msg_ServerNameFileMissing() =>
            $"The file that defines the name of the server that hosts the Tingen Web Service cannot be found.{Environment.NewLine}" +
            Environment.NewLine +
            $"Please verify the \"AppData\\Runtime\\tngncmdr.servername\" file exists and contains a valid server name.";
    }
}
