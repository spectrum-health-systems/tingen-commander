// ███ █ ██  █  ██   ███ ██  █
//  █  █ █ █ █ █  ██ ██  █ █ █
//  █  █ █  ██  ███  ███ █  ██
//
//  ██  ██  ██ ██ ██ ██  █  ██  █ ███  ███ ███
// █   █  █ █ █ █ █ █ █ ███ █ █ █ █  █ ██  ███
//  ██  ██  █   █ █   █ █ █ █  ██ ███  ███ █  █

// u250319_code
// u250319_documentation

using System.IO;

namespace TingenCommander.Framework
{
    internal static class Directories
    {

        /// <summary>Verify the required directories exist, and create them if they don't.</summary>
        /// <param name="directories">The list of directories to verify.</param>
        internal static void Verify(List<string> directories)
        {
            foreach (var directory in directories)
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
            }
        }

        /// <summary>Rename directories.</summary>
        /// <param name="directories">The list of directories to rename.</param>
        internal static void Rename(Dictionary<string,string> directories)
        {
            foreach (var directory in directories)
            {
                if (Directory.Exists(directory.Key))
                {
                    Directory.Move(directory.Key, directory.Value);
                }
            }
        }

        /// <summary>Remove depreciated directories.</summary>
        /// <param name="directories">The list of directories to remove.</param>
        internal static void Remove(List<string> directories)
        {
            foreach (var directory in directories)
            {
                if (Directory.Exists(directory))
                {
                    Directory.Delete(directory, true);
                }
            }
        }
    }
}