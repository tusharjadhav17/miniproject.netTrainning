using MyConsoleAppEFA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleAppEFA
{
    public class Studenti
    {
       public void insertStud()
       {
            TrainingDbContext context = new TrainingDbContext();
            {
                Student obj = new Student();

                Console.WriteLine("Enter the Number : ");
                int num = Convert.ToInt32(Console.ReadLine());

                for(int i=0; i<num; i++)
                {
                    Console.WriteLine("Enter the StudentId : ");
                    obj.StudentId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the SName : ");
                    obj.Sname = Console.ReadLine();

                    Console.WriteLine("Enter the DeptId : ");
                    obj.DeptId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Location : ");
                    obj.Location = Console.ReadLine();

                    

                }
                context.Students.Add(obj);
                context.SaveChanges();
            }
       }
    }
}
