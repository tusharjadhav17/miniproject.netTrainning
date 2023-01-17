using System;
using System.Linq;

namespace LinqConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 0, 2, 4, 5, 6,7 };
            //int[] b = { 1, 3, 5, 7, 8 ,9};
            //int dp = a.Zip(b, (a,b) => a * b).Sum(); 
            //Console.WriteLine($"dp : {dp} ");
            //Console.WriteLine("Hello World!");

            //int[] a = { 0, 2, 3, 5, 6, 7, 8, 9 };
            //int[] b = { 1,0,4,7,6,8,9 };
            //var p = from x in a
            //        from y in b
            //        where x < y
            //        select (x, y);
            //Console.WriteLine("p where x < y : ");
            //foreach(var p1 in p) 
            //{
            //    Console.WriteLine($"{p1.x} less then {p1.y} ");
            //}


            int[] a = { 1, 2, 4, 6, 5, 8 };
            int i = 0;

            var q = (from x in a
                     select ++i).ToList();
            foreach(var v in q ) 
            {
                Console.WriteLine($" v = {v} , i = {i}");
            }
            foreach (var v in q)
            {
                Console.WriteLine($" v = {v} , i = {i}");
            }

        }
    }
}
