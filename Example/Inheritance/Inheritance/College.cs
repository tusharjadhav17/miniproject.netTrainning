using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance 
{
    internal class College 
    {
        public int clgcode;
        public string clgname;       
        public string clgdept;
        public string clglocation;

        public void getData()
        {
            Console.WriteLine("\n\tCollege information :\n");
            Console.ReadLine();
          
            Console.Write("Enter Clgname : ");
            clgname = Console.ReadLine();           
            Console.Write("Enter clgdept : ");
            clgdept = Console.ReadLine();
            Console.Write("Enter the clglocation : ");
            clglocation = Console.ReadLine();
            Console.Write("Enter clgcode : ");
            clgcode = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();
            Console.WriteLine($"clgname : {clgname} ");
            Console.WriteLine($"clgdept : {clgdept} ");
            Console.WriteLine($"clglocation : {clglocation} ");
            Console.WriteLine($"clgcode : {clgcode} ");

            
        }
        
    }
}
