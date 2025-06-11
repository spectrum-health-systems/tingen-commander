// u250121_code
// u250109_documentation

namespace TingenCommander
{
    /// <summary>Pre-defined data.</summary>
    class Catalog
    {
        /// <summary>Message when Tingen Commander cannot find the location of Tingen data.</summary>
        /// <param name="configTngnData">The location of Tingen web service data, according to the configuration.</param>
        /// <returns>A message to the user letting them know that the Tingen web service data location was not found.</returns>
        internal static string MsgTngnDataLocationNotFound(string configTngnData)
        {
            return $"According to the Tingen Commander configuration file, Tingen data should be located here:\n\n" +
                $" * {configTngnData.ToUpper()}\\ (Standard Mode)\n\n" +
                $"Please verify the configuration file.";
        }
    }
}