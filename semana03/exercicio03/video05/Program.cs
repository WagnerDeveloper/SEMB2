using System; //arquivos em c#
using System.IO;


namespace exercicio03
{
    class program
    {
        public static void Main(string [] args)
        {
        
        string nomeDoArquivo = "documetos.txt";

        string conteudo = File.ReadAllText(nomeDoArquivo);

        Console.WriteLine("conteudo do arquivo");
        Console.WriteLine(conteudo);
        Console.WriteLine("\n");

        File.AppendAllText(nomeDoArquivo, "Um outro arquivo.");

        conteudo = File.ReadAllText(nomeDoArquivo);
        Console.WriteLine(conteudo);
         Console.WriteLine("\n");

        Console.ReadKey(true);
        }
    }
}