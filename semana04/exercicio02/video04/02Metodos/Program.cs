using System;

namespace _02Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person p1 = new Person();
            p1.presents();
            p1.presents("Wagner Neves");
            p1.presents("Wagner Neves", 24);

        }
    }
}
