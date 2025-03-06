using System; //arquivos em c#
using System.IO;


namespace exercicio03
{
    class program
    {
        public static void Main(string [] args)
        {
        
        string nomeDoArquivo = "documetos.txt";

        string[] documentos = File.ReadAllLines(nomeDoArquivo);

        foreach(string documento in documentos)
            Console.WriteLine(documento);

        Console.ReadKey(true);
        }
    }
}