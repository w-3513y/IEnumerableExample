using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExample
{
    class IEnumExample
    {
        private readonly List<int> listExample = new();

        public IEnumExample()
        {
            InsertList();
        }

        void InsertList()
        {
            System.Console.WriteLine($"insertList");
            for (int x = 0; x < 900000001; x++)
            {
                listExample.Add(x);
            }
            System.Console.WriteLine($"finishList");
        }

        public IEnumerable<int> notToListReturn()
        {
            return listExample.Where(x => x > 0);
        }


        public IEnumerable<int> toListReturn()
        {
            return listExample.Where(x => x > 0).ToList();
        }

        public void WriteNotToList()
        {
            Console.WriteLine($"notToListStart");
            var result = notToListReturn();
            Console.WriteLine(result.Count());
            foreach (var str in result)
            {
                //Console.WriteLine(str);
            }
            System.Console.WriteLine($"notToListFinish");
        }

        public void WriteToList()
        {
            System.Console.WriteLine($"toListStart");
            var result = toListReturn();
            Console.WriteLine(result.Count());
            foreach (var str in result)
            {
                //Console.WriteLine(str);
            }
            System.Console.WriteLine($"toListfinish");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEnumExample example = new();
            //5490 MB RAM usage
            System.Console.WriteLine("notToList: ");
            example.WriteNotToList();
           //6000 MB RAM usage
            System.Console.WriteLine("ToList(): ");
            example.WriteToList();
        }
    }
}
