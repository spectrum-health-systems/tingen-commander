using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TingenCommander
{
    public class Session
    {
        public string DataPath { get; set; }

        public static void CreateSettings()
        {
            var settings = new Session
            {
                DataPath = @"C:\Tingen"
            };

            DuJson.ExportToLocalFile<Session>(settings, @"C:\TingenData\Commander\TingenCommanderSettings.json");
        }
    }
}
