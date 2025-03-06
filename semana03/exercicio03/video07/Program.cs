using System; //arquivos em c#
using System.IO;

namespace exercicio03
{
    class program
    {
        public static void Main(string [] args)
        {
        
        string diretorio = "pasta";

        if(Directory.Exists(diretorio)){
            Console.WriteLine("Diretorio existe");
        }
        else{
            Console.WriteLine("Diretorio Não existe");
        }
        
        Console.ReadKey(true);
        }
    }
}