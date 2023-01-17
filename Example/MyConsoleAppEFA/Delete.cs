using Microsoft.EntityFrameworkCore;
using MyConsoleAppEFA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleAppEFA
{
    public class Delete
    {
        public void delete()
        {
            using(var context = new TrainingDbContext())
            {
                /* Company company = new Company();
                 var allCompanys = context.Company.Where(c => c.Company.Count > 0).Include(c => c.Books).ToList();
                 for (int i = 0; i < allCompany.Count; i++)
                 {
                     context.RemoveRange(allCompanys[i].Books);
                 }
                 context.RemoveRange(allCompanys);
                 context.SaveChanges();*/




                var obj = context.Companys.ToList();
                Console.WriteLine("how many record delete in Auther : ");
                int n = Convert.ToInt32(Console.ReadLine());
                int i = 1;
                obj.ForEach(item =>
                {
                    //  Book = new List<Book>();
                    // List<Book> list = new List<Book>();
                    if (i <= n)
                    {
                        context.Companys.Remove(item);
                    }
                    i++;
                }
                );
            }
            

        }
    }
}
