using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorPP
{
    internal class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public override double GetArea()
        {
            return _width * _height;
        }

        public override double GetCircumference()
        {
            return 2 * _height + 2 * _width;
        }

        public Rectangle(string name, int width, int height) : base(name)
        {
            _name = name;
            _width = width;
            _height = height;
        }
    }
}
