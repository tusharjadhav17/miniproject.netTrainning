using System;

namespace Encapsulation
{
    internal class Program
    {
       /* static int Sum(int x, int y)
        {
            int a = x;
            int b = y;

            int result = a + b;
            return result;
        }*/
        public int Add(int a, int b,int c)
        {
            int sum = a + b + c;
            return sum;
        }
        public static void Main(string[] args)
        {
            Program program= new Program();

            

            int sum1 = program.Add(12, 23,10);
            Console.WriteLine($"sum of :{ sum1}");
            Console.WriteLine("sum of the : "+int.Parse(sum1.ToString()));  

           /* int a = 12;
            int b = 13;

            int c = Sum(a, b);

            Console.WriteLine(c);*/
        }



    }
}
