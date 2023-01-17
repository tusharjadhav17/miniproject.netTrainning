using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace FourConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>()
            {
                new Student(){ID = 1, Name = "tushar" ,Gender = "male" },
                new Student(){ID = 2, Name = "abc" , Gender = "female"},
                new Student(){ID = 3, Name = "xyz" ,Gender = "male" }
            };
            IQueryable<Student> MethodSyntax = studentsList.AsQueryable()
                .Where(std => std.Gender == "Male");
            foreach(var student in MethodSyntax) 
            {
                Console.WriteLine($" ID = {student.ID} Name = {student.Name}");
            }
            Console.ReadKey();
            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
        }
        

    }
}
