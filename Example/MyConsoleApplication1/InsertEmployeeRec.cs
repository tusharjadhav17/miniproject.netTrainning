using Microsoft.EntityFrameworkCore;
using MyConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication1
{
    internal class InsertEmployeeRec
    {
        public void insertemployeerec()
        {
            using (var context = new TrainingDbContext())
            {
                int cnt = 10;
                int count = 100;
                while (cnt > 0)
                {
                    List<Employee> lstEmployees = new List<Employee>();

                    for (int i = 0; i < count; i++)
                    {

                        Employee employee = new Employee()
                        {

                            Email = string.Format("test{0}@yopmail.com", i.ToString()),
                            JobName = string.Format("FirstName{0}", i.ToString()),
                            EmpName = string.Format("LastName{0}", i.ToString()),
                            Address = string.Format("Address{0}", i.ToString()),
                            DeptId =string.Format("12",i.ToString()),

                        };

                        lstEmployees.Add(employee);
                        
                    }
                    context.AddRange(lstEmployees);
                    context.SaveChanges();
                    cnt--;
                }
            }
           

        }
        public void Delete()
        {
            // delete the data in table
            using (var context = new TrainingDbContext())
            {
                var std2 = context.Employees.ToList();
               // var std3 = context.Books.ToList();
                foreach (var item in std2)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Email :-  " + item.Email);
                   // Console.WriteLine("FirstName :-  " + item.FirstName);
                   // Console.WriteLine("LastName :- " + item.LastName);
                }

                Console.WriteLine("how many record delete in Auther : ");
                int n = Convert.ToInt32(Console.ReadLine());
                int i = 1;
                std2.ForEach(item =>
                {
                    //  Book = new List<Book>();
                    // List<Book> list = new List<Book>();
                    if (i <= n)
                    {
                        context.Employees.Remove(item);
                    }
                    i++;
                }
                );
            }
               
        }
    }
}
