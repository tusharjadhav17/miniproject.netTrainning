using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsoleApp1
{
    internal class Class2
    {
        public string name;
        public int a;
        public int n;
        public int c;
        public void Add() 
        {
            Console.WriteLine("Enter the name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the value :");
            a = Convert.ToInt32(Console.ReadLine());    
        }
        public void setData()
        {
            sbyte a = 126;

            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
        }
        public void getData()
        {

        }
    }
}
