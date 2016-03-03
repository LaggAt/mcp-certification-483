using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fundamentals
{
    class Rectangle : AbstractPolygon, IShape
    {
        
        /// <summary>
        /// Member inherited from interface IShape
        /// </summary>
        public string ShapeColor { get; set; }

        public Rectangle()
        {
        }
        /// <summary>
        /// When invoked, this constructor will call the constructor 
        /// of the base class : AbstractPolygon.
        /// </summary>
        /// <param name="w"></param>
        /// <param name="l"></param>
        public Rectangle(double w, double l) : base(w, l)
        {
            //base(w, l); // error
        }
        /// <summary>
        /// Implementing virtual AbstractPolygon.GetArea()
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return Width * Length;
        }
        public double GetPerimeter()
        {
            return (Width + Length) * 2;
        }
        /// <summary>
        /// Overriding virtual AbstractPolygon.GetName()
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "Rectangle";
        }
        /// <summary>
        /// Implemented from interface IShape
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfSides()
        {
            return 4;
        }
    }
}
