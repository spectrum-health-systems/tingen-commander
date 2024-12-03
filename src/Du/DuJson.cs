//// u241021.1131_code
//// u241023_documentation

//using System.IO;
//using System.Text.Json;

//namespace TingenCommander.Du
//{
//    /// <summary>Provides various JSON functionality.</summary>
//    public static class DuJson
//    {
//        /// <summary>Export JSON data to an external file.</summary>
//        /// <typeparam name="JsonObject">The JSON object type.</typeparam>
//        /// <param name="jsonObject">The JSON object.</param>
//        /// <param name="filePath">The export file path.</param>
//        /// <param name="formatJson">Determines if the JSON data is formatted.</param>
//        public static void ExportToLocalFile<JsonObject>(JsonObject jsonObject, string filePath, bool formatJson = true)
//        {
//            var jsonFormat = new JsonSerializerOptions();

//            jsonFormat.WriteIndented = formatJson;

//            var fileContent = JsonSerializer.Serialize(jsonObject, jsonFormat);

//            File.WriteAllText(filePath, fileContent);
//        }

//        /// <summary>Convert a JSON object to a string[].</summary>
//        /// <typeparam name="JsonObject">The JSON object type.</typeparam>
//        /// <param name="jsonObject">The JSON object.</param>
//        /// <returns>A JSON object as a string[].</returns>
//        public static string ConvertToString<JsonObject>(JsonObject jsonObject)
//        {

//            return JsonSerializer.Serialize(jsonObject);
//        }

//        /// <summary>Import JSON data from an external file.</summary>
//        /// <typeparam name="JsonObject">The JSON object type.</typeparam>
//        /// <param name="filePath">The import file path.</param>
//        /// <returns>The contents of the file as a JSON object.</returns>
//        public static JsonObject ImportFromLocalFile<JsonObject>(string filePath)
//        {


//            var configurationFileContents = File.ReadAllText(filePath);

//            return JsonSerializer.Deserialize<JsonObject>(configurationFileContents);
//        }
//    }
//}