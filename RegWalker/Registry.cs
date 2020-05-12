using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegWalker
{
    class RegHelper
    {
       public  static string ReadSubKeyValue(string subKey, string key)

        {

            string str = string.Empty;

            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(subKey))

            {

                if (registryKey != null)

                {

                    str = registryKey.GetValue(key).ToString();

                    registryKey.Close();

                }

            }

            return str;

        }

       public static List<string> GetChildSubKeys(string key)

        {

            List<string> lstSubKeys = new List<string>();

            try

            {

                using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(key))

                {

                    if (!(registryKey == null))

                    {

                        int MaxValues = registryKey.ValueCount;

                        string[] values = registryKey.GetValueNames();
                      foreach(string s in values)
                        {
                            string hexVal = BitConverter.ToString((byte [])registryKey.GetValue(s));

                            byte[] valbytes = Utility.FromHex(hexVal);

                           string val = Encoding.ASCII.GetString( valbytes);
                            Regex rgx = new Regex("[^a-zA-Z0-9\x2E\x2C]");
                            val = rgx.Replace(val, "");

                            lstSubKeys.Add(val);

                        }

                    }

                }

            }

            catch(Exception ex)

            {
                Console.WriteLine(ex.Message);
                //Write your custom exception handling code here

            }

            return lstSubKeys;

        }
    }
}
