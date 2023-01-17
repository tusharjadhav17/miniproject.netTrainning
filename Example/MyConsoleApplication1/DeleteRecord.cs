using Microsoft.EntityFrameworkCore;
using MyConsoleApplication1.Model;
using System.Data;

namespace MyConsoleApplication1
{
    internal class DeleteRecord
    {
        public void Delete()
        {
            using (var context = new TrainingDbContext())
            {

                // List<Auther> dobj = context.Authers.Take(1).ToList();
                // context.Authers.Remove(obj);
                /*
                                var std = context.Authers.First();
                                context.Remove(std);

                                var std1 = context.Books.First();
                                context.Remove(std1);*/
                //using var context = new TrainingDbContext();


                //context.SaveChanges();

                var std2 = context.Authers.ToList();
                var std3 = context.Books.ToList();
                foreach (var item in std2)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Email :-  " + item.Email);
                    Console.WriteLine("FirstName :-  " + item.FirstName);
                    Console.WriteLine("LastName :- " + item.LastName);
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
                        context.Authers.Remove(item);                      
                    }
                    i++;
                }
                );
                /*foreach (var item1 in std3)
                {
                    Console.WriteLine("BookName :- " + item1.Name);
                    Console.WriteLine("publisher :- " + item1.Publisher);
                }
                Console.WriteLine("delete Book ");
                std3.ForEach(item1 =>
                {
                  //  List<Book> list = new List<Book>();
                    if (i <= n)
                    {
                        context.Books.Remove(item1);
                    }
                    i++;
                }
                );
               */
                
               // std3.Authers.Add(std2);

              // context.Books.Add(std3);
                context.SaveChanges();                   
            }
            
        }
        public void BDelete()
        {
            using (var context = new TrainingDbContext())
            {
                var std3 = context.Books.ToList();

                Console.WriteLine("How many record delete in book : ");
                int n = Convert.ToInt32(Console.ReadLine());
                int i = 1;
                

                foreach (var item1 in std3)
                {
                    Console.WriteLine("BookName :- " + item1.Name);
                    Console.WriteLine("publisher :- " + item1.Publisher);
                }
                Console.WriteLine("delete Book ");
                std3.ForEach(item1 =>
                {
                    if (i <= n)
                    {
                        context.Books.Remove(item1);
                    }
                    i++;
                }
                );
                context.SaveChanges();
            }
            
        }
      /*  public void getDelete()

        {
            using var context = new TrainingDbContext();

            var blog = context.Authers.OrderBy(e => e.Name).Include(e => e.Books).First();
            int i= 1;
            foreach (var Rec in blog.Books)
            {
                if( i <= 2)
                {
                    Rec.Author = null;
                    
                }
                context.Authers.Remove(blog);
                i++;
               
            }
           

            context.SaveChanges();
        }*/


    }
}
