using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorPP
{
    internal abstract class Shape
    {
        private protected string _name;

        public Shape(string name)
        {
            _name = name;
        }

        public abstract double GetArea();

        public abstract double GetCircumference();

        public void ShowInfo()
        {
            Console.WriteLine($"Navn: {_name}");
            Console.WriteLine($"Areal: {GetArea()}");
            Console.WriteLine($"Omkrets: {GetCircumference()}");
        }

        public string GetName()
        {
            return _name;
        }
    }
}