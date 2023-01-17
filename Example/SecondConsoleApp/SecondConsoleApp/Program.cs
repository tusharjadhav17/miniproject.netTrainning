using System;

namespace SecondConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike= new Bike();
            bike.Update("FZ");
            bike.ChangeGear(4);
            bike.SpeedUp(300);
            bike.ApplayBreak(2);
            bike.Display(4321);

            Console.WriteLine("\n\tPress Enter");
            Console.ReadLine();
            Console.WriteLine("Bike Details: \n"); 
            bike.printstate();
            Console.WriteLine("\n\tPress Enter");
            Console.ReadLine();

           Bicycle bicycle= new Bicycle();
            bicycle.Update("yz");
            bicycle.SpeedUp(10);
            bicycle.ApplayBreak(2);
            bicycle.ChangeGear(4);
            bicycle.Display(1234);

            Console.WriteLine("Bicycle Details : \n");
            bicycle.put();
            Console.WriteLine("\n\tPress Enter ");
            Console.ReadLine(); 
        }
    }
}
