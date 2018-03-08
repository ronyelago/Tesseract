using System;
using Mocr.Extractor;

namespace Mocr
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ronye.rocha\Desktop\TravaLingua.jpg";
            string text = Extract.ExtractTextFromImage(path);

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\n---Fim---\n");
            Console.ReadLine();
        }

    }
}
