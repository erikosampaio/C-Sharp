using System;
using System.IO;

namespace FileAndFiloInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"D:\Users\Sampaio\ws-vs2022\C-Sharp\Lessions\FileAndFiloInfo\file1.txt";
            string targetPath = @"D:\Users\Sampaio\ws-vs2022\C-Sharp\Lessions\FileAndFiloInfo\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
