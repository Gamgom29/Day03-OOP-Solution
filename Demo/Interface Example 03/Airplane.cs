using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_03
{
    class Airplane : Vechile, IMovable, IFlyable
    {
        public void Backward() // Implicitly
        {
            Console.WriteLine("Airplane Move Backward On Ground");
        }
        void IMovable.Forward() // Explicitly
        {
            Console.WriteLine("Airplane Move Forward On Ground");
        }

        void IFlyable.Forward() // Explicitly
        {
            Console.WriteLine("Airplane Move Forward On Air");
        }

    }
}
