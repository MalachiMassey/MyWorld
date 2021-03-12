using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace MyWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            if (args.Length > 0)
            {
                string fileName = args[0];
                if (File.Exists(fileName))
                {
                    string extension = Path.GetExtension(fileName);
                    if (extension == ".zip")
                    {
                        try
                        {
                            ZipFile.ExtractToDirectory(fileName, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft\\saves"));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Extraction Successful! Press any key to close window.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("There was an error. Check that the world has not been previously imported to Minecraft.");
                            Console.WriteLine(e.ToString());
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Press any key to quit.");
                            Console.ReadLine();
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("You need to run this application with a .zip file passed as an argument.");
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }
        }
    }
}
