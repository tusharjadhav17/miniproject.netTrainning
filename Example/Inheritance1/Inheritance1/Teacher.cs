using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    internal class Teacher : Student1
    {
        public string tname;

        public void getData()
        {
            Console.WriteLine("Enter the t info : ");
            tname = Console.ReadLine();
        }
        public void get()
        {
            Console.ReadLine(); 
            Console.WriteLine("Enter the t name : "+ tname);
        }
    }
   
}
