using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegWalker
{
    class Program
    {
        static void Main(string[] args)
        {
          List<string> RecentFiles =  RegHelper.GetChildSubKeys(Constants.REG_MRU);

            foreach (string s in RecentFiles)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
