using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
        string name = " tushar ";

        public virtual void showData()
        {
            Console.WriteLine("web side name : " + name);
        }
    }
    class web : Class1
    {
        string sname = "Computer ";

        public override void showData()
        {
            base.showData();
            Console.WriteLine("About : " + sname);
        }
    }
    

}
