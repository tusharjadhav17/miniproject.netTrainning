using System;
using System.ComponentModel;

namespace SolidConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
         // Class2 class2 = new Class2();
         // class2.Add();
         // class2.setData();
        //  ArrayS arrays = new ArrayS();
         // arrays.getData();
         // arrays.Display();
     //  Statement statement= new Statement();

            Console.WriteLine("Hello World!");


            for(int i=0;i<9;i++)
            {
                if(i==4)
                {
                    continue;
                }
                Console.WriteLine("hello" + i);
            }
         // int n =Convert.ToInt32(Console.ReadLine());
            //switch(n)
            //{
         ////   //    case 1:
         ////   //        Console.WriteLine("hiii");
         ////   //        break;
         ////   //    case 2:
         ////   //        Console.WriteLine("tushar");
         ////   //        goto case 1;
         ////   //    case 3:
         ////   //        Console.WriteLine("jadhav");
         ////   //        goto case 2;
         ////   //    default:
         ////   //        Console.WriteLine("Invalid");
         ////   //        break; 
         ////   //}
            int n = 5;
           print(n);
           
        }
      static void print(int n)
        {
            if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5)
            {
                Console.WriteLine("10");
            }
            else if (n == 12 || n == 13 || n == 14)
            {
                Console.WriteLine("122");
            }
            else if (n == 10)
            {
                Console.WriteLine("111");
            }
        }

        Public static void details(string name, int id, string dept = "comp", string grp = "A+")
        {
            Console.WriteLine("Employee name : " + name);
        }
        static public void main()
        {

        }
    }
}
