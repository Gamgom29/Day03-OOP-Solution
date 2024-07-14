using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_02
{    // Developer 02 --> ahmed

    class SeriesByTwo : ISeries 
    {
        public int Current { get; set; }        

        public void GetNext()
        {
            Current += 2;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
