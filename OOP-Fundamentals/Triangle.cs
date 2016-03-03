using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fundamentals
{
    class Triangle : AbstractPolygon, IShape
    {

        public string ShapeColor { get; set; }

        public override double GetArea()
        {
            return (Width * Length) / 2;
        }
        public double GetPerimeter()
        {
            // not the right answer
            return (Width + Length) / 2;
        }
        public override string GetName()
        {
            return "Triangle";
        }
        /// <summary>
        /// Implemented from interface IShape
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfSides()
        {
            return 3;
        }
    }
}
