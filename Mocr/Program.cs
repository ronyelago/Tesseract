using System;
using Mocr.Extractor;
using Mocr.CreateFile;
using System.Diagnostics;

namespace Mocr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho da imagem desejada: ");
            string path = @Console.ReadLine();

            string text = Extract.ExtractTextFromImage(path);

            Console.Write("\nA parada foi extraída. Agora, escolha um nome para o arquivo: ");
            string name = Console.ReadLine();

            Console.WriteLine("\n\n\nSalvando a porra toda...\n");
            FileGenerator.CreateFile(@"C:\Users\ronye.rocha\Desktop\" +name+ ".txt", text);

            Console.WriteLine("\n\nAbrindo o rolê...");
            Process.Start(@"C:\Users\ronye.rocha\Desktop\" + name + ".txt");

            Console.WriteLine("\n\n\n---Fim---\n");
            Console.ReadLine();
        }

    }
}
