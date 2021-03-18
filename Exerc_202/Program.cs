using System;
using System.Collections.Generic;
using System.IO;
using Exerc_202.Entities;

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
                    List<Funcionario> list = new List<Funcionario>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    list.Sort();

                    foreach (Funcionario item in list)
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
