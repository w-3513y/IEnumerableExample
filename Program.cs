using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IEnumerableExample
{
    class IEnumExample
    {
        private readonly List<int> teste = new();
        Stopwatch stopwatch = new Stopwatch();

        public IEnumExample()
        {
            InsertList();            
            stopwatch.Start();
        }

        void InsertList()
        {
            TimeSpan ts = stopwatch.Elapsed;
            System.Console.WriteLine($"insertList: {stopwatch.ElapsedMilliseconds}");
            for (int x = 0; x < 900000001; x++)
            {
                teste.Add(x);
            }
            System.Console.WriteLine($"finish: {stopwatch.ElapsedMilliseconds}");
        }

        public IEnumerable<int> Teste()
        {
            return teste.Where(x => x > 0);
        }


        public IEnumerable<int> Teste2()
        {
            return teste.Where(x => x > 0).ToList();
        }

        public void Escreve()
        {
            System.Console.WriteLine($"start: {DateTime.Now:HH:mm:ss}");
            var retorno = Teste();
            Console.WriteLine(retorno.Count());
            foreach (var str in retorno)
            {
                //Console.WriteLine(str);
            }
            System.Console.WriteLine($"finish: {DateTime.Now:HH:mm:ss}");
        }

        public void Escreve2()
        {
            System.Console.WriteLine($"start: {DateTime.Now:HH:mm:ss}");
            var retorno = Teste2();
            Console.WriteLine(retorno.Count());
            foreach (var str in retorno)
            {
                //Console.WriteLine(str);
            }
            System.Console.WriteLine($"finish: {DateTime.Now:HH:mm:ss}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEnumExample example = new();
            System.Console.WriteLine("notToList: ");
            example.Escreve();
            System.Console.WriteLine("ToList(): ");
            example.Escreve2();
        }
    }
}
