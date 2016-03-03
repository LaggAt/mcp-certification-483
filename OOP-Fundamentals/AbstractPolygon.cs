using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fundamentals
{
    abstract class AbstractPolygon
    {
        public double Width { get; set; }

        public double Length { get; set; }

        public AbstractPolygon()
        {
        }

        public AbstractPolygon(double w, double l)
        {
            Width = w;
            Length = l;
        }

        public abstract double GetArea();

        public virtual string GetName()
        {
            return "AbstractPolygon";
        }
    }
}
