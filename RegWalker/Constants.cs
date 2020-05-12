using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegWalker
{
   public  class Constants
    {
        public static string REG_STARTUP = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        public static string REG_MRU = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\RecentDocs";
    }
}
