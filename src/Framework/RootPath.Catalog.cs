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
    internal static partial class RootPath
    {
        /// <summary>Let the user know the file that defines the Tingen Commander root directory cannot be found.</summary>
        /// <returns>A message letting the user know the file that defines the Tingen Commander root directory cannot be found.</returns>
        public static string Msg_CmdrRootFileMissing() =>
            $"The file that defines the Tingen Commander root directory for cannot be found.{Environment.NewLine}" +
            Environment.NewLine +
            $"Please verify the \"AppData\\Runtime\\tngncmdr.rootpath\" file exists and contains a valid root directory for Tingen Commander.";

        /// <summary>Let the user know the defined root directory for Tingen Commander is not valid.</summary>
        /// <returns>A message letting the user know the defined root directory for Tingen Commander is not valid.</returns>
        public static string Msg_CmdrRootInvalid(string rootPath) =>
            $"The Tingen Commander root directory defined in \"AppData\\Runtime\\tngncmdr.root\" cannot be found.{Environment.NewLine}" +
            Environment.NewLine +
            $"Would you like to create this directory now?{Environment.NewLine}" +
            Environment.NewLine +
            $"Click \"OK\" to create \"{rootPath}\"{Environment.NewLine}" +
            $"Click \"Cancel\" to exit Tingen Commander.";
    }
}