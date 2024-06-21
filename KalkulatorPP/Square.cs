using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorPP
{
    internal class Square : Shape
    {
        private int sideLength;
        public override double GetArea()
        {
            return sideLength*sideLength;
        }

        public override double GetCircumference()
        {
            return sideLength*4;
        }

        public Square(string name, int side) : base(name)
        {
            _name = name;
            sideLength = side;
        }
    }
}
