using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    internal class College : Student1
    {
        public string cname;
        public string caddr;
        public int ccode;

        public void accept()
        {
            Console.WriteLine("Enter the College info :");
            cname = Console.ReadLine();
            caddr = Console.ReadLine();
            ccode = Convert.ToInt32(Console.ReadLine());
        }
        public void set()
        {
            Console.WriteLine("enter c name : " + cname);
            Console.WriteLine("enter c address : " + caddr);
            Console.WriteLine("enter c code : " + ccode);
        }

    }
}
