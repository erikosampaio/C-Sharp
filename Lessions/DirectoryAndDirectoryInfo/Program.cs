using System;
using System.IO;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"D:\Users\Sampaio\ws-vs2022\C-Sharp\Lessions\DirectoryAndDirectoryInfo\myfolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
