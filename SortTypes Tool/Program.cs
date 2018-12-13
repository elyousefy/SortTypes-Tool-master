using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTypes_Tool
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "SortTypes Tool";

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome to SortTypes Tool.");
            Console.ResetColor();
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Enter the path (ex: C:\\Users\\):");

            string filepath = Console.ReadLine();
            DirectoryInfo d = new DirectoryInfo(filepath);


            foreach (var file in d.GetFiles("*.*"))
            {
                string filename = file.Name;
                string[] filenames = filename.Split('.');

                string extension = filenames[filenames.Length - 1];
                Directory.CreateDirectory(@"C:\SortTypes\" + extension);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Copy in progress !");
                Console.ResetColor();
                Console.WriteLine(filename);
                File.Copy(filepath + @"\" + filename, @"C:\SortTypes\" + extension + @"\" + filename, true);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Copy file successfully !");
                Console.ResetColor();
                Console.WriteLine("");
            }
            //code
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Finish !");
            Console.WriteLine("Go to C:\\SortTypes\\ !");
            Console.ResetColor();
            Console.WriteLine("Press any key to exit...");
            System.Diagnostics.Process.Start("explorer.exe", @"C:\SortTypes");
            Console.ReadKey();
        }
    }
}
