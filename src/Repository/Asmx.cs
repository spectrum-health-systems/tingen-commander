// u250121_code
// u250109_documentation

using System.IO;

using TingenCommander.Du;

namespace TingenCommander.Repository
{
    internal class Asmx
    {
        internal static void DownloadUrl(string sessionRoot, string asmxName, string url)
        {

                //DuInternet.DownloadUrl(url, $@"{sessionRoot}\{asmxName}.asmx");
        }






        internal static void DownloadFiles(string sessionRoot, string MainUrl, string DevelopmentUrl)
        {
            //DuInternet.DownloadUrl(MainUrl, $@"{sessionRoot}\Main.asmx");
            //DuInternet.DownloadUrl(DevelopmentUrl, $@"{sessionRoot}\Development.asmx");
        }

        //internal static Dictionary<string, string> GetVersions(string sessionRoot, string MainUrl, string DevelopmentUrl)
        //{
        //    //DownloadFiles(sessionRoot, MainUrl, DevelopmentUrl);

        //    //return new Dictionary<string, string>
        //    //{
        //    //    { "MainBranch", GetVersion($@"{sessionRoot}\MainBranch.asmx") },
        //    //    { "DevelopmentBranch",GetVersion($@"{sessionRoot}\DevelopmentBranch.asmx") }
        //    //};
        //}

        internal static string GetVersion(string sessionRoot, string url)
        {
            var asmxName = url.Contains("main")
                ? "main"
                : "dev";

            var targetPath = $@"{sessionRoot}\{asmxName}.asmx";

            DuInternet.DownloadUrl(url, targetPath);



            string asmxVersion = "Unknown";

            if (File.Exists(targetPath))
            {
                using (StreamReader reader = new(targetPath))
                {
                    asmxVersion = reader.ReadLine() ?? "";
                }

                asmxVersion = asmxVersion.Replace("//", "");
                asmxVersion = asmxVersion.Replace("=", "");
            }

            return asmxVersion.Trim();
        }
    }
}