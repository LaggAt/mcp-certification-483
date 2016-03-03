using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Type
            int i = 5;
            int x = i; // x = 5
            i = 7; // x = 5

            object o1 = 5;
            Object o2 = o1; // o = 5
            o1 = 7; // o2 = 5
            Console.WriteLine("o2 : " + o2);

            // Reference Type
            Person p1 = new Person
            {
                Name = "Mohamed"
            };
            Person p2 = p1;
            p1.Name = "Ahmed";
            Console.WriteLine("p2.Name : " + p2.Name); // Ahmed

            // 'enum' type uses Value Type
            DepartmentsEnum departmentsEnum1 = DepartmentsEnum.GI;
            DepartmentsEnum departmentsEnum2 = departmentsEnum1;
            departmentsEnum1 = DepartmentsEnum.GM;
            Console.WriteLine("departmentsEnum2 : " + departmentsEnum2); // DepartmentsEnum.GI

            Console.ReadLine();
        }
    }
}
