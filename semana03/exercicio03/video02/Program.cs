using System; //arquivos em c#
using System.IO;


namespace exercicio03
{
    class program
    {
        public static void Main(string [] args)
        {
        string arquivo = "arquivo.txt";
        
        string texto = File.ReadAllText(arquivo);

        Console.WriteLine("conteudo do arquivo: " + texto);

        Console.ReadKey(true);
        }
    }
}