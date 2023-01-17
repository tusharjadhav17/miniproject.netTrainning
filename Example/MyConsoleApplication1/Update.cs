using MyConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication1
{
    internal class Update
    {
        public void update()
        {
           // var obj = new Auther() { Id = 1, LastName = "tushar" };

            //obj.LastName = "abc";

           // var book = new Book() { Id = 1, Publisher = "abcd" };

            Auther obj = new Auther();
            using (var context = new TrainingDbContext())
            {
                // context.Update<Auther>(obj);
                var Res = context.Authers.First();
                Res.Id = 1;

                context.SaveChanges();

            }      
        }
        public void getData()
        {
            Auther obj = new Auther();
            Book book = new Book();
            using (var context = new TrainingDbContext())
            {
                var Res = context.Authers.ToList();
                var Res2 = context.Books.ToList();
                
                foreach(var item in Res) 
                {
                    Console.WriteLine("Email :- " + item.Email);
                    Console.WriteLine("FirstName :- " + item.FirstName);
                    Console.WriteLine("LastName :- "+item.LastName);
                }
                Console.WriteLine("how many record update in Auther : ");
                int n = Convert.ToInt32(Console.ReadLine());
                int i = 1;
                Res.ForEach (item =>
                {
                    if (i <= n)
                    {
                        Console.WriteLine("record update FirstName : ");
                        item.FirstName = Console.ReadLine();
                        context.SaveChanges();
                        Console.WriteLine(item.FirstName);
                    }
                    i++;
                }          
                     
                );


                foreach(var item1 in Res2)
                {
                    Console.WriteLine("BookName :- " + item1.Name);
                    Console.WriteLine("publisher :- "+item1.Publisher);
                }
                Console.WriteLine("update Book ");
                Res2.ForEach(item1 =>
                {
                    if( i <= n)
                    {
                        Console.WriteLine("record update Name :- ");
                        item1.Name = Console.ReadLine(); 
                    }
                    i++;
                }
                );
            }

        }
    }
}
