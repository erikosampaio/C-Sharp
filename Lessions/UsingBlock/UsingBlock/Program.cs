using System;
using System.IO;

namespace FileStreamAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"D:\Users\Sampaio\ws-vs2022\C-Sharp\Lessions\FileAndFiloInfo\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}