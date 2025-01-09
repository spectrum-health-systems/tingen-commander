// b250109.1100
// u250109_code
// u250109_documentation

using System.IO;

using TingenCommander.Du;

namespace TingenCommander.Session
{
    public class CmdrSession
    {
        public string LocalRoot { get; set; }

        public string DataRoot { get; set; }

        public string RemoteRoot { get; set; }

        public static CmdrSession LoadConfiguration(string filePath)
        {
            VerifyConfigFileExists(filePath);

            return DuJson.ImportFromLocalFile<CmdrSession>(filePath);
        }

        public static void ResetSessionData(string dataPath)
        {
            if (Directory.Exists(dataPath))
            {
                Directory.Delete(dataPath, true);
            }

            Directory.CreateDirectory(dataPath);
        }

        private static void VerifyConfigFileExists(string filePath)
        {
            if (!File.Exists(filePath))
            {
                CreateNewConfigFile(filePath);
            }
        }

        private static void CreateNewConfigFile(string filePath)
        {
            var configuration = BuildDefaultSession();

            DuJson.ExportToLocalFile<CmdrSession>(configuration, filePath);
        }

        private static CmdrSession BuildDefaultSession()
        {
            CmdrSession defaultSession = new CmdrSession
            {
                LocalRoot  = @".\AppData",
                RemoteRoot = @"C:\TingenData"
            };

            defaultSession.DataRoot = $@"{defaultSession.LocalRoot}\Session";

            return defaultSession;
        }
    }
}
