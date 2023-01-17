using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start the  run code");    

            Student student = new Student();
            Exam exam = new Exam();
            College college = new College();

           
            college.getData();
            student.Display();
            exam.addData();
           

            Console.WriteLine("End of Code");
            Console.ReadLine();

        }
    }
}
