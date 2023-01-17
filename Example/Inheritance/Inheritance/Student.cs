using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student : College
    {
        public string sname;
        public string sdept;
        public int sdob;
        public int sid;

        public void Display()
        {
            Console.WriteLine("\n\tStudent Information");
            Console.ReadLine();

            Console.Write("\nEnter the student name : ");
            sname= Console.ReadLine();
            Console.Write("Enter the student Dept : ");
            sdept= Console.ReadLine();
            Console.Write("Enter the student id : ");
            sid = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter the student dob : ");
            sdob= Convert.ToInt32( Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine($"snmae : {sname} ");
            Console.WriteLine($"sdept : {sdept} ");
            Console.WriteLine($"sdob : {sdob}");    
            Console.WriteLine($"sid : {sid}");
            Console.ReadLine() ;

            
        }
    }
}
