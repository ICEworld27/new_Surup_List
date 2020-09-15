using System;
using System.Collections;
using System.Collections.Generic;
namespace abs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GGList<int> a = new GGList<int>(5);
            /*
            Console.WriteLine(a);

            Console.WriteLine(a);
            */
            a.Add(5);
            /*
            Console.WriteLine(a);
            Console.WriteLine(a);
            */
            a[0] = 9;
            /*
            Console.WriteLine(a);
            Console.WriteLine(a);
            */
            Console.WriteLine(a.GetE());
            IEnumerator<int> d = a.GetE();
            int za = d.Current; //getValue
            Console.WriteLine(d.Current);
            d.MoveNext(); // next
            Console.WriteLine(d.Current);
            

        }
    }
}
