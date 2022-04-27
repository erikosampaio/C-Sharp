using System;
using System.IO;

namespace SummaryCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            //abrir arquivo
            //instanciar itens de venda do arquivo
            //criar uma subpasta out/summry.csv
            string path = @"D:\Users\Sampaio\ws-vs2022\C-Sharp\Works\SummaryCSV\file1.csv";

            try
            {
                //ler o arquivo
                string[] lines = File.ReadAllLines(path);
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {

                    }
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
