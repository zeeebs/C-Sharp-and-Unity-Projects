using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class integerMath
    {
        public int mathOp(int value)
        {
            return value - 5;
        }
        public decimal mathOp(decimal value)
        {
            return Convert.ToInt32(value - 1);
        }
        public int mathOp(string value)
        {
            int intValue = Convert.ToInt32(value);
            intValue = intValue / 2;
            return intValue;
        }
    }
}
