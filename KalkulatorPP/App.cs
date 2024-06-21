using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorPP
{
    internal class App
    {
        public void Run()
        {
            var shapes = new ShapeList();
            while (true)
            {
                Console.WriteLine("Hva vil du gjøre?");
                Console.WriteLine("1. Lag en ny figur");
                Console.WriteLine("2. Vis alle figurer");
                var userInput = Console.ReadLine();
                var userInputNum = Convert.ToInt32(userInput);

                switch (userInputNum)
                {
                    case 1:
                        shapes.List.Add(CreateShape());
                        break;
                    case 2:
                        foreach (var shape in shapes.List)
                        {
                            Console.WriteLine("*******************");
                            shape.ShowInfo();
                        }

                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("velg noe gyldig n00b");
                            break;
                }
                
            }
        }

        public Shape CreateShape()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hva slags figur vil du lage?");
                Console.WriteLine("1. Sirkel");
                Console.WriteLine("2. Trekant");
                Console.WriteLine("3. Rektangel");
                Console.WriteLine("4. Kvadrat");
                var userInput = Console.ReadLine();
                int userInputNum = Convert.ToInt32(userInput);

                switch (userInputNum)
                {
                    case 1:
                        return CreateCircle();
                    case 2:
                        return CreateTriangle();
                    case 3:
                        return CreateRectangle();
                    case 4:
                        return CreateSquare();
                    default:
                        Console.WriteLine("Ugyldig input. Trykk for å gå videre..");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public Triangle CreateTriangle()
        {
            Console.Clear();
            Console.WriteLine("Hva skal lengden på basen være?");
            var userBaseInput = Console.ReadLine();
            var userBaseInputNum = Convert.ToInt32(userBaseInput);

            Console.Clear();
            Console.WriteLine("Hva skal høyden være?");
            var userHeightInput = Console.ReadLine();
            var userHeightInputNum = Convert.ToInt32(userHeightInput);

            Console.Clear();
            Console.WriteLine("Navn pls");
            var userNameInput = Console.ReadLine();

            var triangle = new Triangle(userNameInput, userHeightInputNum, userBaseInputNum);

            triangle.ShowInfo();
            Console.ReadKey();
            return triangle;
        }
        public Circle CreateCircle()
        {
            Console.Clear();
            Console.WriteLine("Hva skal diameteren være?");
            var userInput = Console.ReadLine();
            var userInputNum = Convert.ToInt32(userInput);

            Console.Clear();
            Console.WriteLine("Navn pls");
            var userNameInput = Console.ReadLine();

            var circle = new Circle(userNameInput, userInputNum);

            circle.ShowInfo();
            Console.ReadKey();
            return circle;
        }
        public Rectangle CreateRectangle()
        {
            Console.Clear();
            Console.WriteLine("Hva skal bredden være?");
            var userInput = Console.ReadLine();
            var userInputNum = Convert.ToInt32(userInput);

            Console.Clear();
            Console.WriteLine("Hva skal høyden være?");
            var userInput2 = Console.ReadLine();
            var userInputNum2 = Convert.ToInt32(userInput);

            Console.Clear();
            Console.WriteLine("Navn pls");
            var userNameInput = Console.ReadLine();

            var rectangle = new Rectangle(userNameInput, userInputNum, userInputNum2);

            rectangle.ShowInfo();
            Console.ReadKey();
            return rectangle;
          

        }
        public Square CreateSquare()
        {
            Console.Clear();
            Console.WriteLine("Hva skal lengden på sidene være?");
            var userInput = Console.ReadLine();
            var userInputNum = Convert.ToInt32(userInput);

            Console.Clear();
            Console.WriteLine("Navn pls");
            var userNameInput = Console.ReadLine();

            var square = new Square(userNameInput, userInputNum);

            square.ShowInfo();
            Console.ReadKey();
            return square;
        }
    }
}
