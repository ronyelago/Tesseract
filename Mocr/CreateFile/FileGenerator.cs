using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocr.CreateFile
{
    class FileGenerator
    {
        //
        // Summary:
        //     Cria um arquivo de texto maroto.
        //
        // Parameters:
        //   path:
        //     Caminho onde o arquivo será salvo juntamente com o seu nome.
        //     Exemplo de path: C:\Users\ronye.rocha\Desktop\NomeDoArquivo.txt
        //
        // Returns:
        //     Retorna bosta nenhuma.
        public static void CreateFile(string path, string content)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(content);
                }
            }
        }
    }
}
