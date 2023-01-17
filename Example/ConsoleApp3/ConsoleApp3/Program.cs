using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj;
            obj = new BaseClass();
            obj.show();

            obj = new Derived();
            obj.show();
            Console.ReadLine();

            /*
                        BaseClass baseclass = new BaseClass();
                        baseclass.show();

                        baseclass = new Derived();
                        baseclass.show();*/


            web w = new web();
            w.showData();
        }
    }
}
