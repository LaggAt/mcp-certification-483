using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fundamentals
{
    interface IShape
    {

        string ShapeColor { get; set; }

        int GetNumberOfSides();
    }
}
