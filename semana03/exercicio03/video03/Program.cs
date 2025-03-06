using System; //arquivos em c#
using System.IO;


namespace exercicio03
{
    class program
    {
        public static void Main(string [] args)
        {
        string[] documentos = {"documento 1.", "documento 2." };
        
        string nomeDoArquivo = "documetos.txt";

        File.WriteAllLines(nomeDoArquivo, documentos);

        Console.WriteLine("O arquivo foi criado");

        Console.ReadKey(true);
        }
    }
}