using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    internal class Student1
    {
        public string sname;
        public int sage;
        public int sid;
        public string location;

        public void Display()
        {
            sname = Console.ReadLine();
            location= Console.ReadLine();
            sage = Convert.ToInt32(Console.ReadLine());
            sid = Convert.ToInt32(Console.ReadLine());
        }
        public void Update()
        {
            Console.WriteLine("student info : Enter press: ");
            Console.ReadLine();
            Console.WriteLine("Enter the student name : "+sname);
            Console.WriteLine("Enter the sudent Location : " + location);
            Console.WriteLine("Enter the student id : "+sid);
            Console.WriteLine("Enter the student student age : " + sage);

        }
    }
}
