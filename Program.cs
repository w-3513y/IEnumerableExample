using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExample
{
    class Program
    {
        static private readonly List<int> listExample = new();
        static private int counter = 0;
        public static void InsertList()
        {
            System.Console.WriteLine($"insertList");
            for (int x = 0; x < 9000001; x++)
            {
                listExample.Add(x);
            }
            System.Console.WriteLine($"finishList");
        }

        static public IEnumerable<int> notToListReturn()
        {
            var result = listExample.Where(x => x > 0);
            return result.Select(p =>
            {
                counter++;
                return p;
            });
        }

        static public IEnumerable<int> toListReturn()
        {
            var result = listExample.Where(x => x > 0);
            return result.Select(p =>
            {
                counter++;
                return p;
            }).ToList();
        }

        static public void WriteNotToList()
        {
            System.Console.WriteLine($"notToListStart");
            var result = notToListReturn();            
            //System.Console.WriteLine(result.Count());
            //counter return zero - return value if you use Count()
            System.Console.WriteLine("counter:" + counter);
            System.Console.WriteLine($"notToListFinish");
        }

        static public void WriteToList()
        {
            System.Console.WriteLine($"toListStart");
            var result = toListReturn();
            //counter return values
            //System.Console.WriteLine(result.Count());
            System.Console.WriteLine("counter:" + counter);
            System.Console.WriteLine($"toListfinish");
        }

        static void Main(string[] args)
        {
            InsertList();
            //5490 MB RAM usage
            WriteNotToList(); //comment to run WriteToList
            //6000 MB RAM usage
            //WriteToList(); //comment to run WriteNotToList
        }
    }
}