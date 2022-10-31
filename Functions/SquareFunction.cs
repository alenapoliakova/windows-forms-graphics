using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class SquareFunction : IFunction
    {
        public double calc(double x)
        {
            // returns y for function y = x^2
            return x * x;
        }
    }
}
