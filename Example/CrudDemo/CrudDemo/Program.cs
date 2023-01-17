using System;
using System.Security.Cryptography.X509Certificates;

namespace CrudDemo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dog dog= new Dog();
            dog.name = "abc";

            dog.Display();
            dog.getName();

            Console.ReadLine();
        }
    }
}
