// u250123_code
// u250123_documentation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TingenCommander
{
    internal class Repository
    {
        public string MainUrl { get; set; }
        public string MainVersion { get; set; }
        public string DevUrl { get; set; }
        public string DevVersion { get; set; }


        internal static Repository Initialize()
        {
            const string cmdrData   = @".\AppData";

            paths.CmdrData   = cmdrData;
            paths.CmdrConfig = $@"{cmdrData}\TingenCommanderSettings.json";
            paths.TngnServer = @"C:\TingenData";

            return "";
        }
    }
}
