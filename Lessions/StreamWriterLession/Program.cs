using System;
using System.IO;

namespace StreamWriterLession
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"D:\Users\Sampaio\ws-vs2022\C-Sharp\Lessions\StreamWriterLession\file1.txt";
            string targetPath = @"D:\Users\Sampaio\ws-vs2022\C-Sharp\Lessions\StreamWriterLession\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
