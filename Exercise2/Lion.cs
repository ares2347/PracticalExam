using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Lion : Animal
    {
        public Lion(double weight)
        {
            base.SetMe(weight, "Lion");
        }
    }
}
