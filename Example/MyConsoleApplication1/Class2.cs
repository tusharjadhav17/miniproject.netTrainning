using Microsoft.EntityFrameworkCore;
using MyConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication1
{
    internal class Class2
    {

      
      

        public void inserta()
        {
            using (var context = new TrainingDbContext())
            {
                Auther obj = new Auther();
                Auther obj1 = new Auther();
              //  Book book = new Book();

                obj.Email = "tur@12";
                obj.FirstName = "tusar";
                obj.LastName = "jadav";

                obj1.Email = "omkr@123";
                obj1.FirstName = "omar";
                obj1.LastName = "sa";


                context.Authers.Add(obj);
                context.Authers.Add(obj1);

                Book book1 = new Book();
                book1.Name = "abc";
                book1.Publisher = " xyz";

                obj.Books.Add(book1);
                
                context.Authers.Add(obj);


                //context.Update<Auther>(obj);
                context.SaveChanges();


            }
    
        }
        public void DeleteRecord()
        {
           

            using (var context = new TrainingDbContext())
            {

                var lit = context.Authers.OrderBy(c => c.Id).Skip(10).Take(10).ToList();

                Console.ReadLine();

               

                // insert the data in table

                //                int cnt = 10;
                //                int count = 100;
                //                while (cnt > 0)
                //                {
                //                    List<Auther> lstAuthers = new List<Auther>();

                //                    for (int i = 0; i < count; i++)
                //                    {

                //                        Auther auther = new Auther()
                //                        {
                //                            AddedDate = DateTime.Now,
                //                            Email = string.Format("test{0}@yopmail.com",i.ToString()),
                //                            FirstName = string.Format("FirstName{0}", i.ToString()),
                //                            LastName = string.Format("LastName{0}", i.ToString()),
                //                            Ipaddress = 127,
                //                            ModifiedDate = DateTime.Now
                //                        };

                //                        lstAuthers.Add(auther);
                //;                    }
                //                    context.AddRange(lstAuthers);
                //                    context.SaveChanges();
                //                    cnt--;
                //                }
                
                // delete the data in table

                //var lit = (from c in context.Authers
                //          from b in context.Books
                //          where c.Id == b.AuthorId
                //          select c).ToList();

                //var allAuthers = context.Authers.Where(c => c.Books.Count > 0).Include(c => c.Books).ToList();
                //for (int i = 0; i < allAuthers.Count; i++)
                //{
                //    context.RemoveRange(allAuthers[i].Books);
                //}
                //context.RemoveRange(allAuthers);
                //context.SaveChanges();

            }
            

        }
    }
}
