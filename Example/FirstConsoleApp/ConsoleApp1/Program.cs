using FirstConsoleApp;
using System;

namespace FirstConsoleApp
{
    public class FirstConsoleApp
    {
        static void Main(string[] args)
        {
            
            IEmployee employee = new Employee();
        
            Console.WriteLine(employee.GetName());
           
            employee.SetName(Console.ReadLine());

            Console.WriteLine(employee.GetName());
            
            employee.SetName(employee.GetDefaultName());

            Console.WriteLine(employee.GetName());


            employee.SetName(employee.DisplayName());

            Console.WriteLine(employee.DisplayName());
            
            Console.ReadLine();
        }
    }
}
