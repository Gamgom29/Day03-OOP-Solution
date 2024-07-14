using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_03
{
    class Car : Vechile, IMovable
    {
        public void Forward()
        {
            throw new NotImplementedException();
        }
        public void Backward()
        {
            throw new NotImplementedException();
        }


    }
}
