// u250121_code
// u250109_documentation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TingenCommander
{
    class Catalog
    {
        internal static string ModeError(string path)
        {
            return $"Tingen Commander cannot find any of the following required directories:\n\n" +
                $" * C:\\TingenData\\ (Administrator Mode)\r\n" +
                $" * {path.ToUpper()}\\ (Standard Mode)\n\n" +
                $"Please verify one of these directories exists, then restart Tingen Commander.";
        }
    }
}
