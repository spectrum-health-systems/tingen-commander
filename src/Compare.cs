// u250121_code
// u250109_documentation

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TingenCommander
{
    internal class Compare
    {
        ////private Dictionary<string, string>GetAsmxVersions(string sessionRoot)
        ////{
        ////    return new Dictionary<string, string>
        ////    {
        ////        { "MainBranch", GetVersion($@"{sessionRoot}\MainBranch.asmx") },
        ////        { "DevelopmentBranch",GetVersion($@"{sessionRoot}\DevelopmentBranch.asmx") }
        ////    };
        ////}

        ////public static string GetVersion(string filePath)
        ////{
        ////    string asmxVersion = "Unknown";

        ////    if (File.Exists(filePath))
        ////    {
        ////        using (StreamReader reader = new(filePath))
        ////        {
        ////            asmxVersion = reader.ReadLine() ?? "";
        ////        }

        ////        asmxVersion = asmxVersion.Replace("//", "");
        ////        asmxVersion = asmxVersion.Replace("=", "");
        ////    }

        ////    return asmxVersion.Trim();
        ////}
    }
}
