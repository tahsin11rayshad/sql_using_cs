using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    internal static class utility2
    {
        //To create a new txt file
        public static void writedbname(string dname)
        {
            string newpath = utility.dir + "/" + "dbnamelist.txt";
            try
            {
                if(File.Exists(newpath))
                {
                    StreamWriter sw = File.AppendText(newpath);
                    string q = $"{dname}";
                    sw.WriteLine(q);
                    sw.Close();
                }
                else
                {
                    //StreamWriter sw = File.AppendText(newpath);
                    string q = $"{dname}";
                    File.WriteAllText(newpath, q);
                    //sw.WriteLine(q);
                    //sw.Close();
                }
            
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
