using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExample
{
    class Program
    {
        static private readonly List<int> listExample = new();
        public static void InsertList()
        {
            System.Console.WriteLine($"insertList");
            for (int x = 0; x < 900000001; x++)
            {
                listExample.Add(x);
            }
            System.Console.WriteLine($"finishList");
        }

        static public IEnumerable<int> notToListReturn()
        {
            var result = listExample.Where(x => x > 0);
            return result.Select(p => {return p;});
        }

        static public IEnumerable<int> toListReturn()
        {
            var result = listExample.Where(x => x > 0);
            return result.Select(p => {return p;}).ToList();
        }

        static public void WriteNotToList()
        {
            Console.WriteLine($"notToListStart");
            var result = notToListReturn();
            //Console.WriteLine(result.Count());
            System.Console.WriteLine($"notToListFinish");
        }

        static public void WriteToList()
        {
            System.Console.WriteLine($"toListStart");
            var result = toListReturn();
            //Console.WriteLine(result.Count());
            System.Console.WriteLine($"toListfinish");
        }

        static void Main(string[] args)
        {
            InsertList();
            //5490 MB RAM usage
            //WriteNotToList(); //comment to run WriteToList
            //6000 MB RAM usage
            WriteToList(); //comment to run WriteNotToList
        }
    }
}