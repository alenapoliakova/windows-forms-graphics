using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class UserFunction : IFunction
    {
        public double calc(double x)
        {
            // returns y for function y = 2x+5
            return 2 * x + 5;
        }
    }
}
