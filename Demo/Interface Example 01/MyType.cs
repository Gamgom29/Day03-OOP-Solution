using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_01
{
    // Developer 02
    internal class MyType : IMyType /* : --> Implements */
    {
        
        public int Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello World!!");
        }
    }
}
