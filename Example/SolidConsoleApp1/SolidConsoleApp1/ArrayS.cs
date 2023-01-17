using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace SolidConsoleApp1
{
    internal class ArrayS
    {
       

        public void getData()
        {
            bool b  = false;
            bool a = true;
            if(a!=true&&b==false)
            {
                Console.WriteLine("hii ");
            }
            else
            {
                Console.WriteLine("Bye");
            }
        }
        public void Display()
        {
            string a = "tushar";

            a += "jadhav";
           

            Console.WriteLine(a);

            object obj;

            obj = 10;
            Console.WriteLine(obj);

            Console.WriteLine(obj.GetType());

            int x = 101;
            int y = 0956;
            int z = 0xFace;

            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            double p = 123.094;
            double q = 1234.943;

            Console.WriteLine(p);
            Console.WriteLine(q);
                
        }
        public void  a1()
        {
            int[] ab= new int[10];
        }

    }
}
