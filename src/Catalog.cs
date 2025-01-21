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
        internal static string MsgAdminModeError()
        {
            return $"The Administrator mode of Tingen Commander is enabled, but the \"C:\\TingenData\\\" directory does not exist.\n\n" +
                   $"Are you running Tingen Commander on same server that Tingen resides?\n\n" +
                   $"If you aren't, you will need to disable Admin mode in the Tingen Commander configuration file.\n";
        }

        internal static string MsgStandardModeError(string path)
        {
            return $"The Standard User mode of Tingen Commander is enabled, but the \"{path}\" directory that is defined in the configuration file does not exist.\n\n" +
                   $"Please make sure the correct path is set in the configuration file.\n\n";
        }

    }
}
