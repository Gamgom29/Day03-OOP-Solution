using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    interface IShape
    {
        public double Area { get;  }

        void DisplayShapeInfo();
    }
}
