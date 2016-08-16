using System;
using ImportExcel.Business.FileSearcher;

namespace ImportExcel.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the directory to search: ");

            var directory = Console.ReadLine();

            Console.WriteLine("Searching for Excel Files...");

            var fileSearcher =  new ExcelFileSearcher(directory);

            var files = fileSearcher.GetFiles();

            foreach (var file in files)
            {
                Console.WriteLine("Found the file " + file.Name);
            }

            Console.ReadKey();
        }
    }
}
