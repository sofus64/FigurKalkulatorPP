using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorPP
{
    internal class Circle : Shape
    {
        private int _diameter;
        public override double GetArea()
        {
            var radius = _diameter / 2;
            var area = Math.PI * (radius*radius);
            return area;
        }

        public override double GetCircumference()
        {
            return Math.PI * _diameter;
        }

        public Circle(string name, int diameter) : base(name)
        {
            _diameter = diameter;
            _name = name;
        }
    }
}
