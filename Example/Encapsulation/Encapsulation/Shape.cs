using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal abstract class Shape
    {
        public abstract int area();
    }
    class Square : Shape
    {
        public int side;
        public Square(int x = 0) 
        {
            side = x;

        }
        public override int area()
        {
            Console.WriteLine("area of square : ");
            return ( side * side );
        }

    }
}
