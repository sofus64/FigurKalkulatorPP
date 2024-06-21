using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorPP
{
    internal class Triangle : Shape
    {
        private int _height;
        private int _base;

        public Triangle(string name, int height, int baseLength) : base(name)
        {
            _name = name;
            _height = height;
            _base = baseLength;
        }
        public override double GetArea()
        {
            return (_height * _base) / 2;
        }

        public override double GetCircumference()
        {

            int side1 = _height;
            int side2 = _base;
            double side3 = Math.Sqrt(side1 * 2 + side2 * 2);

            double circ = side1 + side2 + side3;

            return circ;
        }
    }
}
