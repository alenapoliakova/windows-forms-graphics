using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class CubeFunction : IFunction
    {
        public double calc(double x)
        {
            // returns y for function y = x^3
            return x * x * x;
        }
        public override string ToString()
        {
            return "y = x^3";
        }
    }
}
