using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Length = 10;

            Rectangle rectangle2 = new Rectangle
            {
                Width = 8,
                Length = 12,
            };

            Console.WriteLine("rectangle.Width : " + rectangle.Width);
            Console.WriteLine("rectangle.Length : " + rectangle.Length);
            Console.WriteLine("rectangle.GetArea() : " + rectangle.GetArea());
            Console.WriteLine("rectangle.GetPerimeter() : " + rectangle.GetPerimeter());

            Rectangle rectangle3 = new Rectangle(13, 9);
            Console.WriteLine("rectangle3.GetArea() : " + rectangle3.GetArea());

            Triangle triangle = new Triangle
            {
                Length = 4,
                Width = 6,
            };
            Console.WriteLine("triangle.GetArea() : " + triangle.GetArea());
            Console.WriteLine("triangle.GetName() : " + triangle.GetName());

            rectangle.ShapeColor = "Blue";
            Console.WriteLine("rectangle3.ShapeColor : " + rectangle.ShapeColor);

            Console.WriteLine("rectangle.GetNumberOfSides() : " + rectangle.GetNumberOfSides());

            Console.WriteLine("Tek Up");
            Console.ReadLine();
        }
    }
}
