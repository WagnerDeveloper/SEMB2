using System; //arquivos em c#
using System.IO;


namespace exercicio03
{
    class program
    {
        public static void Main(string [] args)
        {
        string nomeDoArquivo = "arquivo.txt";
        string texto = "Este é dovumento txt";
        File.WriteAllText(nomeDoArquivo, texto);
        Console.WriteLine("Arquivo criado com sucesso!");

        Console.ReadKey(true);
        }
    }
}