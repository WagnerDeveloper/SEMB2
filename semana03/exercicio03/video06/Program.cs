using System; //arquivos em c#
using System.IO;

namespace exercicio03
{
    class program
    {
        public static void Main(string [] args)
        {
        
        string nomeDoArquivo = "Arquivo.txt";

        Console.WriteLine(File.Exists(nomeDoArquivo));

        File.WriteAllText(nomeDoArquivo, "Algum texto");
      
        Console.WriteLine(File.Exists(nomeDoArquivo));

        Console.ReadKey(true);
        }
    }
}