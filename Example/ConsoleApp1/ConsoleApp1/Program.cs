using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var My_Tuple3 = Tuple.Create("tushar");

            Console.WriteLine("Element of tuple : "+My_Tuple3.Item1);
            Console.WriteLine();

            var My_Tuple1 = Tuple.Create(12, 23, 45,50);

            Console.WriteLine("Element of My_tuple : " + My_Tuple1.Item1);
            Console.WriteLine("Element of My_tuple : " + My_Tuple1.Item2);
            Console.WriteLine("Element of My_tuple : " + My_Tuple1.Item3);
            Console.WriteLine("Element of My_tuple : " + My_Tuple1.Item4);
            Console.WriteLine();

            var My_Tuple2 = Tuple.Create("tu", 1, 33, 44, "jadhav", 6, 't', 2.09);

            Console.WriteLine("Element of My_tuple1 : " + My_Tuple2.Item1);
            Console.WriteLine("Element of My_tuple2 : " + My_Tuple2.Item2);
            Console.WriteLine("Element of My_tuple3 : " + My_Tuple2.Item3);
            Console.WriteLine("Element of My_tuple4 : " + My_Tuple2.Item4);
            Console.WriteLine("Element of My_tuple5 : " + My_Tuple2.Item5);
            Console.WriteLine("Element of My_tuple6 : " + My_Tuple2.Item6);
            Console.WriteLine("Element of My_tuple7 : " + My_Tuple2.Item7);
            
            Console.WriteLine("Element of My_tuple8 : " + My_Tuple2.Rest);
            //Console.WriteLine("Element of My_tuple " + My_Tuple2.Rest.Item1.Item1);
            //Console.WriteLine("Element of My_tuple " + My_Tuple2.Rest.Item1.Item2);
            //Console.WriteLine("Element of My_tuple " + My_Tuple2.Rest.Item1.Item3);
        }
    }
}
