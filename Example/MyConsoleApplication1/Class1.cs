using MyConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication1
{
    internal class Class1
    {
        public void Display()
        {
            using(var context = new TrainingDbContext())
            {
                Employee eobj = new Employee();

                Console.WriteLine("How many insert in number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                
                for(int i=0;i<num;i++)
                {
                    Console.WriteLine("Enter the EmpId : ");
                    eobj.EmpId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the JobName : ");
                    eobj.JobName = Console.ReadLine();

                    Console.WriteLine("Enter the EmpName : ");
                    eobj.EmpName= Console.ReadLine();

                    Console.WriteLine("Enter the Salary : ");
                    eobj.Salary = Convert.ToInt32(Console.ReadLine());


                   /* context.Employees.Add(eobj);
                    context.SaveChanges();*/

                }
                
                context.Employees.Add(eobj);

                context.SaveChanges();
            }
        }
    }
}
