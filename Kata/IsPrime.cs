using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static partial class Kata
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            else if (n <= 3) return true;
            else if (n % 2 == 0 || n % 3 == 0) return false;

            int counter = 5;
            while (counter * counter <= n)
            {
                if (n % counter == 0 || n % (counter + 2) == 0) return false;
                counter += 6;
            }
            return true;
        }
    }
}
