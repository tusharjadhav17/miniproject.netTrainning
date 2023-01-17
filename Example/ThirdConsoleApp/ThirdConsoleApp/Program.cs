// C# program to illustrate the
// Lambda Expression
using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdConsoleApp
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Press Enter ");
            Console.ReadLine();
            // List to store numbers
            List<int> numbers = new List<int>() {36,50,3, 12,
                            15, 18,20, 17, 9};

            // foreach loop to display the list
            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using lambda expression
            // to calculate square of
            // each value in the list
            var square = numbers.Select(x => x * x);

            // foreach loop to display squares
            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using Lambda expression to
            // find all numbers in the list
            // divisible by 3
            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

            // foreach loop to display divBy3
            Console.Write("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine("\n\n\n\t press Enter ");    
            Console.ReadLine();

            List<int> number = new List<int>() {36,50,71, 12,
                            15, 29, 18, 27, 30};
            Console.Write("The list : ");
            foreach (var value in number)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();    
            var squar = number.Select(x => x * x);
            Console.Write("Squares : ");
            foreach (var value in squar)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            List<int> divBy5 = number.FindAll(x => (x % 5) == 0);
            Console.Write("Number Divisible 5 : ");

            foreach (var value in divBy5)
            {
                Console.Write($"{value} ",value);
            }
            Console.WriteLine();

            Console.WriteLine("\n\n\n\t press Enter ");
            Console.ReadLine();

            Action line = () => Console.WriteLine();

            Console.ReadLine();




            Console.WriteLine("\n\n\tStudent Information :\n\n ");

            // List with each element of type Student
            List<Class1> details = new List<Class1>() {
            new Class1{ rollNo = 1, name = "Liza" },
                new Class1{ rollNo = 2, name = "Stewart" },
                new Class1{ rollNo = 3, name = "Tina" },
                new Class1{ rollNo = 4, name = "Stefani" },
                new Class1 { rollNo = 5, name = "Trish" }
        };

            // To sort the details list
            // based on name of student
            // in ascending order
            var newDetails = details.OrderBy(x => x.name);

            foreach (var value in newDetails)
            {
                Console.WriteLine(value.rollNo + " " + value.name);
            }
            Console.WriteLine("\n\n\n\tpress Enter ");
            Console.ReadLine();

            Action<string> greet = name =>
            {
                Console.WriteLine("\n Enter the Input : ");
                string gret = Console.ReadLine();
                Console.WriteLine(gret);   
                string greeting = $"Hello {gret}!";
                Console.WriteLine(gret);
            };
            greet("World");
            Console.ReadLine();


            Action<int> abc = num => 
            {
                Console.WriteLine("Enter the integer ");
                int ab = Console.Read();
                Console.WriteLine(ab);
                int xz = ab;
                Console.WriteLine(xz);


            };
            abc(50);
            Console.ReadLine();




            Console.WriteLine("\n\n\tStudent Information :\n\n ");

            // List with each element of type Student
            List<Form1> detail = new List<Form1>() {
            new Form1{ rollNo = 1, name = "abc" },
                new Form1{ rollNo = 2, name = "cbs" },
                new Form1{ rollNo = 3, name = "axd" },
                new Form1{ rollNo = 4, name = "erf" },
                new Form1 { rollNo = 5, name = "edf" }
            };
            var newDetail = detail.OrderBy(x => x.name);

            foreach (var valu in newDetail)
            {
                Console.WriteLine(valu.rollNo + " " + valu.name);
            }

        }
    }
}
