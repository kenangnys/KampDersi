using System;
using System.Collections.Generic;
using System.Text;

namespace RefAndOutParameters
{
    class Referans
    {
        public void Numbers(ref int i, ref int k)
        {
            i = i + k;
        }

    }
}
