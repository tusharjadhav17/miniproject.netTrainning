using MyConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication1
{
    internal class Insert
    {
        public void insert()
        {
            using (var context = new TrainingDbContext())
            {
                Auther obj = new Auther();
                Book book = new Book();
                

                Console.WriteLine("How many record insert in number :");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Auther details : ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter {i+1} Record");

                    Console.WriteLine("Enter the Email :");
                    obj.Email = Console.ReadLine();

                    Console.WriteLine("Enter the firstname : ");
                    obj.FirstName = Console.ReadLine();

                    Console.WriteLine("Enter the lastName : ");
                    obj.LastName = Console.ReadLine();

                    obj.Books.Add(book);
                    context.Authers.Add(obj);
                   // context.SaveChanges();

                }
                Console.WriteLine("Book details :");
                for(int i=0;i<n;i++)
                {
                    Console.WriteLine("Enter the book  name : ");
                    book.Name = Console.ReadLine();

                    Console.WriteLine("Enter the Publisher : ");
                    book.Publisher = Console.ReadLine();

                    obj.Books.Add(book);
                    context.Authers.Add(obj);
                  //context.SaveChanges();
                }
               /* obj.Books.Add(book);
                context.Authers.Add(obj);*/
                context.SaveChanges();


            }

        }
    }
}
