using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
  
    class Program
    {
        
        static void Main(string[] args)
        {

            List<int> l = new List<int>();

            l.Add(5);
            l.Add(12);
            l.Add(2);
            l.Add(32);
            l.Add(0);
            l.Add(120);
            l.Add(6);
            l.Add(12);
            l.Add(2);

            Console.WriteLine(l.Contains(7));
            Console.WriteLine(l.Exists(i=> i>7));
            Console.WriteLine(l.IndexOf(120));
            Console.WriteLine(l.LastIndexOf(12));
            Console.WriteLine(l.LastIndexOf(12,3));
            Console.WriteLine(l.LastIndexOf(2,4,3));
            Console.WriteLine(l.Find(i=> i>5));
            List<int> store = l.FindAll(i => i > 5);

            store.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(l.FindLast(i=> i>0));
            Console.WriteLine(l.FindIndex(i => i == 120));
            Console.WriteLine(l.FindLastIndex(i => i > 2));
            Console.WriteLine(l.FindLastIndex(3,i=> i>2));
            Console.WriteLine(l.FindLastIndex(7,7,i=> i>12));
            

            Console.ReadKey();
        }
    }
}
