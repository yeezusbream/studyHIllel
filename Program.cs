using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the way to file: ");
            string sourcePath = Console.ReadLine();

            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Error: File didn` founded.");
                return;
            }
            Console.Write("Enter the way to file, where you need copy data: ");
            string destinationPath = Console.ReadLine();

            File.Copy(sourcePath, destinationPath, overwrite: true);

           
            Console.WriteLine("File copyed succesfull!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: insufficient rights to access files.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error entering/output: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
