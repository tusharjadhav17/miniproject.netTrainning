using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public class Bicycle : IVahical
    {
        int speed;
        int gear;
        int bbreak;
        int num;
        string name;

        public void Update(String namme1)
        {
            name = namme1;
        }
        public void ChangeGear(int newgear)
        {
            gear = newgear;
        }
        public void SpeedUp(int newspeed)
        {
            speed = speed + newspeed;
            //speed = speed + pspeed;
        }
        public void ApplayBreak(int newapplay)
        {
            bbreak = bbreak + newapplay;
        }
        public void Display(int num1)
        {
            num = num1;
        }
        public void put()
        {
            Console.WriteLine("\tBicycle name : " + name);
            Console.WriteLine("\tBicycle no : " + num);
            Console.WriteLine("\tspeed : " + speed);
            Console.WriteLine("\tgear : "+gear);
            Console.WriteLine("\tapplayBreak : " + bbreak);
            
           

        }
    }
}
