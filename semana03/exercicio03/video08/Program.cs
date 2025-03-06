using System; //arquivos em c#
using System.IO;

namespace exercicio03
{
    class program
    {
        public static void Main(string [] args)
        {
        
        string pasta = "Nova pasta";
        Directory.CreateDirectory(pasta);
        Console.ReadKey(true);

        }
    }
}