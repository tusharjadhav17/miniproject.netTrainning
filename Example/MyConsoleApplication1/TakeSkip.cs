using MyConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyConsoleApplication1
{
    internal class TakeSkip
    {
        public void Take()
        {
            using (var context = new TrainingDbContext())
            {
                Console.WriteLine("Enter the Page No : ");

                int pn = Convert.ToInt32(Console.ReadLine());
                int ps = 10;

                if (pn == 0)
                {
                    Console.WriteLine("Invalid page");

                }
                else
                {
                    var res = context.Authers.OrderBy(c => c.Id).Skip((pn - 1) * ps).Take(ps).ToList();
                    foreach (var c in res)
                    {
                        if (pn == 1 && c.Id <= 10)
                        {
                            Console.WriteLine(++(c.Id) + " " + c.AddedDate + " " + c.Email + " " + c.FirstName + " " + c.LastName + " " + c.Ipaddress + " " + c.ModifiedDate);
                        }
                        if (pn >= 2)
                        {
                            Console.WriteLine(++(c.Id) + " " + c.AddedDate + " " + c.Email + " " + c.FirstName + " " + c.LastName + " " + c.Ipaddress + " " + c.ModifiedDate);
                        }
                        if (pn == 0)
                        {
                            break;
                        }
                    }
                }
                while (true)    
                {
                    Console.WriteLine("Next Page Press : 0 and 1 ");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                    {
                        ++pn;
                    }
                    else if (ch == 0)
                    {
                        --pn;
                    }
                    try
                    {
                        var res = context.Authers.OrderBy(c => c.Id).Skip((pn) * ps).Take(ps).ToList();
                        foreach (var c in res)
                        {
                            if (pn == 1 && c.Id <= 10)
                            {
                                Console.WriteLine(++(c.Id) + " " + c.AddedDate + " " + c.Email + " " + c.FirstName + " " + c.LastName + " " + c.Ipaddress + " " + c.ModifiedDate);
                            }
                            if (pn >= 1)
                            {
                                Console.WriteLine(++(c.Id) + " " + c.AddedDate + " " + c.Email + " " + c.FirstName + " " + c.LastName + " " + c.Ipaddress + " " + c.ModifiedDate);
                            }
                            if (pn == 0)
                            {
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid page ");
                    }
                }              

            }

        }
    }   
}
