using System;
using System.Diagnostics;
using ProgAssincrona; // Certifique-se de que este namespace está correto

namespace Program 
{
    class ProgramAssincrona
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ExecutarcomTasks();
            sw.Stop();
            Console.WriteLine($"Tempo decorrido: {sw.ElapsedMilliseconds} ms");
            
            Console.ReadKey();
        }   
        
        static void RealizarOperacao(int op, string nome, string sobrenome)
        {
            Console.WriteLine($"Iniciando operação {op}...");
            for (int i = 0; i < 1000000000; i++)
            {
                var p = new Pessoa(nome, sobrenome, 35);
            }
            Console.WriteLine($"Finalizando operação {op}...");
        }
        
        static void ExecutarSequencial()
        {
            RealizarOperacao(1, "João", "Silva");
            RealizarOperacao(2, "Maria", "Silva");
            RealizarOperacao(3, "Antonio", "Silva");
        }

        static void ExecutarComThreads()
        {
            var t1 = new Thread(() =>
            {
                RealizarOperacao(1, "João", "Silva");
            });
            var t2 = new Thread(() =>
            {
                RealizarOperacao(2, "Maria", "Silva");
            });
            var t3 = new Thread(() =>
            {
                RealizarOperacao(3, "Antonio", "Silva");
            });
            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join(); 
            t3.Join();
        }

        static void ExecutarcomTasks()
        {
            var t1 = Task<int>.Run(() =>
            {
                RealizarOperacao(1, "João", "Silva");
                return 1;
            });
            var t2 = Task<int>.Run(() =>
            {
                RealizarOperacao(2, "Maria", "Silva");
                return 2;
            });
            var t3 = Task<int>.Run(() =>
            {
                RealizarOperacao(3, "Antonio", "Silva");
                return 3;
            });
            Console.WriteLine($"Tarefa{t1.Result} finalizada");
            Console.WriteLine($"Tarefa{t2.Result} finalizada");
            Console.WriteLine($"Tarefa{t3.Result} finalizada");
        }
    }
}
