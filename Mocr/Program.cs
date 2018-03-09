using System;
using Mocr.Extractor;
using Mocr.CreateFile;

namespace Mocr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho da imagem desejada: ");
            string path = @Console.ReadLine();

            //string path = @"C:\WorkSpace\Mocr\Mocr\Capturar.jpg";
            string text = Extract.ExtractTextFromImage(path);

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n\n\nSalvando a porra toda...\n");

            FileGenerator.CreateFile(@"C:\Users\ronye.rocha\Desktop\NomeDoArquivo.txt", text);

            Console.WriteLine("\n\n\n---Fim---\n");
            Console.ReadLine();
        }

    }
}
