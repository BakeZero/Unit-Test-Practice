using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    internal class OddEven
    {
        public string DoOddEven(int x)
        {
            if (IsPrime(x))
                return "PRIME";
            else if (x % 2 == 0)
                return "EVEN";
            else
                return "ODD";
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = number-2; i >= 3; i -= 2)
            {
                if (number % i == 0 && i != 1)
                    return false;
            }

            return true;
        }
    }
}
