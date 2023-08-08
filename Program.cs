using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(@"type 'commands' to know the commands. or make any command");

            while (true)
            {
                string cmd = Console.ReadLine();
                if(cmd == "exit")
                {
                    break;
                }

                else if(cmd == "commands") // ishmaam
                {
                    utility.print_commands();                
                }

                else if(cmd.Contains("create database"))
                {
                    string input = cmd;
                    // Find the index where "create database" ends and get the substring after that
                    int index = input.IndexOf("create database");
                    if (index != -1)
                    {
                        string databaseName = input.Substring(index + "create database".Length).Trim();
                        utility.create_database(databaseName);
                        /*Console.WriteLine(databaseName);*/
                    }
                    else
                    {
                        Console.WriteLine("Command is not correct - 'create database your_database_name'");
                    }
                }
            }
                           



            Console.WriteLine("Database Closed");
            Console.ReadLine();
        }
    }
}
