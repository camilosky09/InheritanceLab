using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public static class File_Reader
    {
        const string FileName = "employees.txt";
        public static string[] ReadAllEmployees()
        {
            string resDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res");

            // Combine the directory and file name to get the full path
            string filePath = Path.Combine(resDirectory, FileName);

            try
            {
                // Read the contents of the file
                // return File.ReadAllText(filePath);
                string content = File.ReadAllText(filePath);
                string[] contentByLine = content.Split('\n');
                return contentByLine;


            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
            return null;
        }
    }
}
