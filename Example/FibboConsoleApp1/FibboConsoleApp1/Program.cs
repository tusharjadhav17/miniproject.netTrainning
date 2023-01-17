using System;
using System.Collections.Generic;

namespace FibboConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibbno = new List<int> { 1, 1 };

            while(fibbno.Count <  20 ) 
            {
                var first = fibbno[fibbno.Count - 1];
                var second = fibbno[fibbno.Count - 2];

                fibbno.Add(first + second);
            }
            foreach(var item in fibbno)
            {
                Console.WriteLine(item);
            }
        }
    }
}
