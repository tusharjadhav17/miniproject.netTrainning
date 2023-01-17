using System;

namespace Inheritance
{
    internal class Exam : Student
    {
        public int mark;
        public int num;
        public string subname;
        float per;
        int sum;

        public void addData()
        {
            Console.WriteLine("\n\tExam information : ");
            Console.ReadLine();

            Console.Write("\nEnter the num  of sub :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the subname : ");
            for (int i = 0; i < num; i++)
            {
                subname = Console.ReadLine();
            }
            Console.ReadLine();

            Console.WriteLine("Enter the mark : ");
            //  num= Convert.ToInt32(Console.ReadLine() );
            for (int i = 0; i < num; i++)
            {
                mark = Convert.ToInt32(Console.ReadLine());
                sum = sum + mark;

            }
            Console.WriteLine($"sum :{sum} ");

            per = (sum / num) * 1;
            Console.WriteLine($"per : {per} %");

            if (per > 90)
            {
                Console.WriteLine("A gread");
            }
            else if (per > 80)
            {
                Console.WriteLine("B gread");
            }
            else if (per > 70)
            {
                Console.WriteLine("C gread");
            }
            else if (per > 60)
            {
                Console.WriteLine("D gread");
            }
            else if (per > 50)
            {
                Console.WriteLine("E gread");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Pass gread");
            }
            else if (per < 40)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("INVALID");
            }
        }
       
        

    }
}
