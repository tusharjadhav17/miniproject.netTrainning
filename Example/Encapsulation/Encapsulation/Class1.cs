using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Class1
    {
        private int rn = 1000;

        public int Rn
        {
            get
            {
                return rn;
            }
            set
            {
                rn = 10;
            }

        }
    }
}
