using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_01
{
    // Developer 01
    internal interface IMyType
    {
        // default access modifier inside interface is "Public"
        // private access modifier isn't allowed inside the inteface for signatures

        // What you can write inside interface ? 
        // 1. Signature for property
        int Salary { get; set; }

        /// 2. Siganture for method 
        void MyFun();

        ///public string SayHello
        ///{
        ///    get { return "Hello"; }
        ///}

        /// 3. Default implemented method -> C# 8.0 feature [.NET core 3.1 (2019)]
        void Print()
        {
            Console.WriteLine("Hello Default Implemented method From interface");
        }
    }
}
