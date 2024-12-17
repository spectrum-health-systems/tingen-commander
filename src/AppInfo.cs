// u241217.1143_code
// u241217_documentation

using System.Reflection;

namespace TingenCommander
{
    public static class AppInfo
    {
        /// <summary>Build the Tingen Commander version information.</summary>
        /// <param name="releaseStage">The release stage (e.g., "Alpha", "Beta")</param>
        /// <remarks>
        /// If <c>releaseStage</c> is passed as an empty string (e.g., <c>""</c>), only the version number will be used.
        /// </remarks>
        /// <returns>The Tingen Commander version string.</returns>
        public static string BuildVersionInfo(string releaseStage)
        {
            if (!string.IsNullOrWhiteSpace(releaseStage))
            {
                releaseStage = $"({releaseStage})";
            }

            return $"Tingen Commander - v{Assembly.GetExecutingAssembly().GetName().Version} {releaseStage}";
        }
    }
}