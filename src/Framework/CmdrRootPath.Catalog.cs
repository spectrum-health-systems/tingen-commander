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
    internal static partial class CmdrRootPath
    {
        public static string cat_PathIsInvalidCaption =>
            "Path is invalid!";

        public static string cat_PathIsInvalidMessage(string rootPath) =>
            $"The Tingen Commander root directory defined in \"AppData\\Runtime\\tngncmdr.root\" cannot be found.{Environment.NewLine}" +
            Environment.NewLine +
            $"Would you like to create this directory now?{Environment.NewLine}" +
            Environment.NewLine +
            $"Click \"OK\" to create \"{rootPath}\"{Environment.NewLine}" +
            $"Click \"Cancel\" to exit Tingen Commander.";

        public static string cat_MissingFileCaption => 
            " Missing file: cmdr.rootpath";

        public static string cat_MissingFileMessage =>
            $"The file that defines the Tingen Commander root directory for cannot be found.{Environment.NewLine}" +
            Environment.NewLine +
            "Since this file is required by Tingen Commander, it will be created for you now.";

        public static string cat_CreatedFileCaption =>
            "Created cmdr.rootpath file";

        public static string cat_CreatedFileMessage =>
            $"The cmdr.rootPath file has been created with the following default value:{Environment.NewLine}" +
            Environment.NewLine +
            $"  C:\\TingenWebService_Data\"{Environment.NewLine}" +
            Environment.NewLine +
            "Please re-launch Tingen Commander.";

        public static string cat_CreateFileErrorCaption =>
            "Error creating cmdr.rootpath file";

        public static string cat_CreateFileErrorMessage =>
            $"The cmdr.rootpath file could not be created.{Environment.NewLine}" +
            Environment.NewLine +
            "Try creating the file manually, then re-launching Tingen Commander.";
    }
}