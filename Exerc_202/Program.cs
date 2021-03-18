using System;
using System.Collections.Generic;
using System.IO;

namespace Exerc_202
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();

                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Ocorreu um erro!" + e.Message); ;
            }
        }
    }
}
