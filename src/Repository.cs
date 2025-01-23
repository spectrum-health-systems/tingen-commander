// u250123_code
// u250123_documentation

/* This class is not used yet.
 */

using System.IO;
using TingenCommander.Du;

namespace TingenCommander
{
    internal class Repository
    {
        public string MainBranchUrl { get; set; }
        public string MainBranchVersion { get; set; }
        public string DevBranchUrl { get; set; }
        public string DevBranchVersion { get; set; }

        /* MainUrl = "https://raw.githubusercontent.com/spectrum-health-systems/Tingen-Development/refs/heads/main/src/Tingen_development.asmx.cs",
             DevUrl = "https://raw.githubusercontent.com/spectrum-health-systems/Tingen-Development/refs/heads/development/src/Tingen_development.asmx.cs"
          */

        //internal class Compare
        //{
        //    private Dictionary<string, string> GetAsmxVersions(string sessionRoot)
        //    {
        //        return new Dictionary<string, string>
        //        {
        //            { "MainBranch", GetVersion($@"{sessionRoot}\MainBranch.asmx") },
        //            { "DevelopmentBranch",GetVersion($@"{sessionRoot}\DevelopmentBranch.asmx") }
        //        };
        //    }

        //    public static string GetVersion(string filePath)
        //    {
        //        string asmxVersion = "Unknown";

        //        if (File.Exists(filePath))
        //        {
        //            using (StreamReader reader = new(filePath))
        //            {
        //                asmxVersion = reader.ReadLine() ?? "";
        //            }

        //            asmxVersion = asmxVersion.Replace("//", "");
        //            asmxVersion = asmxVersion.Replace("=", "");
        //        }

        //        return asmxVersion.Trim();
        //    }
        //    /
        //    internal static void DownloadUrl(string sessionRoot, string asmxName, string url)
        //    {

        //        //DuInternet.DownloadUrl(url, $@"{sessionRoot}\{asmxName}.asmx");
        //    }

        //    internal static void DownloadFiles(string sessionRoot, string MainUrl, string DevelopmentUrl)
        //    {
        //        //DuInternet.DownloadUrl(MainUrl, $@"{sessionRoot}\Main.asmx");
        //        //DuInternet.DownloadUrl(DevelopmentUrl, $@"{sessionRoot}\Development.asmx");
        //    }

        //    //internal static Dictionary<string, string> GetVersions(string sessionRoot, string MainUrl, string DevelopmentUrl)
        //    //{
        //    //    //DownloadFiles(sessionRoot, MainUrl, DevelopmentUrl);

        //    //    //return new Dictionary<string, string>
        //    //    //{
        //    //    //    { "MainBranch", GetVersion($@"{sessionRoot}\MainBranch.asmx") },
        //    //    //    { "DevelopmentBranch",GetVersion($@"{sessionRoot}\DevelopmentBranch.asmx") }
        //    //    //};
        //    //}

        //    internal static string GetVersion(string sessionRoot, string url)
        //    {
        //        var asmxName = url.Contains("main")
        //        ? "main"
        //        : "dev";

        //        var targetPath = $@"{sessionRoot}\{asmxName}.asmx";

        //        DuInternet.DownloadUrl(url, targetPath);



        //        string asmxVersion = "Unknown";

        //        if (File.Exists(targetPath))
        //        {
        //            using (StreamReader reader = new(targetPath))
        //            {
        //                asmxVersion = reader.ReadLine() ?? "";
        //            }

        //            asmxVersion = asmxVersion.Replace("//", "");
        //            asmxVersion = asmxVersion.Replace("=", "");
        //        }

        //        return asmxVersion.Trim();
        //    }
        //}
    }
}