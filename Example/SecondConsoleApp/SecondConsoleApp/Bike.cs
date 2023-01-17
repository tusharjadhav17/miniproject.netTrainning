using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public class Bike : IVahical
    {
        int speed;
        int gear;
        int bbreak;
        int num;
        string name;

        public void Update(string name1)
        {
            name= name1;
        }        
        public void ChangeGear(int newgear)
        {
            gear = newgear;
        }
        public void SpeedUp(int newspeed )
        {
            speed= speed + newspeed;
        }
        public void ApplayBreak(int newapplay)
        {
            bbreak= bbreak + newapplay; 
        }
        public void Display(int num2)
        {
            num = num2;
        }
        
        public void printstate()
        {
            Console.WriteLine("\tBike name : " + name);
            Console.WriteLine("\tBike no : " + num);
            Console.WriteLine("\tspeed : "+ speed + "\n\tgear : " + gear);
            Console.WriteLine("\tbreak : " + bbreak);
            
            
        }

       
    }
}
