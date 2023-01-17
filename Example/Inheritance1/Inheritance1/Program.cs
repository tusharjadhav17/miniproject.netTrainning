using System;

namespace Inheritance1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Teacher teacher = new Teacher();
            teacher.getData();
            teacher.get();
            College college = new College();    
            college.accept();
            college.set();

        }
    }
}
