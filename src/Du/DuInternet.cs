// b250109.1155
// u250109_code
// u250109_documentation

using System.Net;

namespace TingenCommander.Du
{
    internal class DuInternet
    {
        /// <summary>
        /// Download data from a URL. [250109]
        /// </summary
        public static void DownloadUrl(string url, string targetPath)
        {
            var client = new WebClient();
            client.DownloadFile(url, targetPath);
        }
    }
}