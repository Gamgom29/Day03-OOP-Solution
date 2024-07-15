using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Circle : ICircle
    {
        public int Radius { get; set; }

        public double Area{ get { return Radius * Radius * 3.14; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Raduis : {Radius} , Area : {Area}");
        }
    }
}
