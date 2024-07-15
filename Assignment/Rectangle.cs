using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle : IRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public double Area 
        { 
            get { return Width * Height; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Width : {Width} , Height : {Height} , Area : {Area}");
        }
    }
}
