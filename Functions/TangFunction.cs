using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class TangFunction : IFunction
    {
        public double calc(double x)
        {
            // returns y for function y = tang(x)
            return Math.Tan(x);
        }
    }
}
