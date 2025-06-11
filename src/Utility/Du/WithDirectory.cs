// ██████╗ ██╗   ██╗
// ██╔══██╗██║   ██║
// ██║  ██║██║   ██║
// ██║  ██║██║   ██║
// ██████╔╝╚██████╔╝
// ╚═════╝  ╚═════╝
// Du.WithDirectory.cs

// u250325_code
// u250325_documentation

using System.IO;

namespace TingenCommander.Utility.Du
{
    internal class WithDirectory
    {
        // u250325
        /// <summary>Verify the a list of required directories exist, and create them if they don't.</summary>
        /// <param name="directories">The list of directories to verify.</param>
        /// <remarks>
        ///   <para>
        ///     Usage:<br/>
        ///     <c>Du.WithDirectory.Verify(listOfDirectoriesToVerify)</c>
        ///   </para>
        /// </remarks>
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

        // u250325
        /// <summary>Rename a dictionary of directories.</summary>
        /// <param name="directories">The list of directories to rename.</param>
        /// <remarks>
        ///   <para>
        ///     Usage:<br/>
        ///     <c>Du.WithDirectory.Rename(dictionaryOfDirectoriesToRename)</c>
        ///   </para>
        /// </remarks>
        internal static void Rename(Dictionary<string, string> directories)
        {
            foreach (var directory in directories)
            {
                if (Directory.Exists(directory.Key))
                {
                    Directory.Move(directory.Key, directory.Value);
                }
            }
        }

        // u250325
        /// <summary>Remove a list of directories.</summary>
        /// <param name="directories">The list of directories to remove.</param>
        /// <remarks>
        ///   <para>
        ///     Usage:<br/>
        ///     <c>Du.WithDirectory.Remove(listOfDirectoriesToRemove)</c>
        ///   </para>
        /// </remarks>
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