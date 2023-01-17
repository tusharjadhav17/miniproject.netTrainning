
using System;
using System.Collections.Generic;

namespace MyConsoleApplication1.Model;
internal class Program
{
    public static void Main(string[] args)
    {


       // Delete delete = new Delete();
       // delete.getDelete();

       // TakeSkip takeSkip = new TakeSkip();
        //takeSkip.Take();



        InsertEmployeeRec obj= new InsertEmployeeRec();
        // obj.insertemployeerec();
        obj.Delete();










        //  Class2 class2 = new Class2();
        //  class2.inserta();
        //  class2.DeleteRecord();

        // Update uobj = new Update();
        // uobj.update();
        // uobj.getData();


        //  DeleteRecord dobj1= new DeleteRecord();
        //  dobj1.BDelete();
        //   dobj1.Delete();
        //  dobj1.getDelete();


        //   Insert iobj = new Insert();
        //   iobj.insert();

        //   Class1 class1 = new Class1();
        //  class1.Display();

        /*using (var context = new TrainingDbContext())
        {

            Auther obj = new Auther();
            {

                obj.AddedDate = DateTime.Now;
                obj.ModifiedDate = DateTime.Now;
                obj.Email = "Sanket@gmail.com";
                // obj.Ipaddress = "127.0.0.1";
                obj.FirstName = "abs";
                obj.LastName = "sanket";


                Book book = new Book();

                book.AddedDate = DateTime.Now;

                book.ModifiedDate = DateTime.Now;
                book.Name = "c#";
                book.Publisher = "add ";

                obj.Books.Add(book);

                context.Authers.Add(obj);

                int cnt = context.SaveChanges();


                Console.WriteLine(cnt);

                context.Authers.Add(obj);
                context.SaveChanges();
            };*/

    }

}
//}
    


