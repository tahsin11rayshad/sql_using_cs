using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    internal static class utility
    {
        public static string dir = @"C:\shuvro_database\";
        public static string curr_dir;
        public static List<string> dbnames = new List<string>();

        

        // To Create A new Database
        public static void create_database(string dbname)
        {
            string targetDirectory = dir + @"/" + dbname + @"/";
            try
            {
                Directory.CreateDirectory(targetDirectory);
                curr_dir = targetDirectory;

                Console.WriteLine("Database created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }






        
        public static void print_commands()
        {
            string commands =   "exit - To Close the database\n"
                              + "commands - To See Commands\n"
                              + "";


            Console.WriteLine(commands);
        }


    }
}
