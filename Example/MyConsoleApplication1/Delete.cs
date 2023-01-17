using MyConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication1
{
    internal class Delete
    {
        public void getDelete()
        {
            Auther obj = new Auther();
            Book bobj = new Book();

            using(var context = new TrainingDbContext())
            {
                var rec = new Auther { Id = 30 };
                context.Authers.Remove(rec);
                
              //  Auther book = context.Book.Find(null);
             //   book.Id = 35;
                context.SaveChanges();
            }

            /* // var res = context.Authers.OrderBy(c => c.Id).Skip((pn-1) * ps).Take(ps).ToList();

              foreach (var c in res)
              {
                  Console.WriteLine(c.AddedDate + " " + c.Email + " " + c.FirstName + " " + c.LastName + " " + c.Ipaddress + " " + c.ModifiedDate);                        
              }*/
            /*switch (n)
            {
                case 1:
                    Console.WriteLine("Next Page Press :N ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'N' || ch == 'n')
                    {
                        var res1 = context.Authers.OrderBy(c => c.Id).Skip((pn) * ps).Take(ps).ToList();

                        foreach (var c in res1)
                        {
                            Console.WriteLine(c.AddedDate + " " + c.Email + " " + c.FirstName + " " + c.LastName + " " + c.Ipaddress + " " + c.ModifiedDate);
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine(" Previous Page Press : P ");
                    char ch1 = Convert.ToChar(Console.ReadLine());
                    if (ch1 == 'P' || ch1 == 'p')
                    {
                        foreach (var c in res)
                        {
                            Console.WriteLine(c.AddedDate + " " + c.Email + " " + c.FirstName + " " + c.LastName + " " + c.Ipaddress + " " + c.ModifiedDate);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }*/

        }
    }
}
