using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class BaseClass
    {
       // public void show() 
        public virtual void show()
        {
            
            Console.WriteLine("base class ");
        }

    }
    class Derived : BaseClass
    {
        //new public void show() 
        public override void show()
        {
            Console.WriteLine("Derived class ");
        }
    }


}
