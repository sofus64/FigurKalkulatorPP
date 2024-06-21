using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorPP
{
    internal class ShapeList
    {
        public List<Shape> List { get; set; }

        public ShapeList()
        {
            List = new List<Shape>()
            {
                new Circle("test1", 43),
                new Square("test2", 9),
                new Rectangle("test3", 4, 7),
                new Triangle("test4", 6, 9),

            };
        }

        public void AddShapeToList(Shape shape)
        {
            List.Add(shape);
        }
    }
}
