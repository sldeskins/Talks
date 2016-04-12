using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveRoutines
{
    public class FibonacciExample
    {
        public static int Fib(int n) {
            if (n<0) {
                throw new ArgumentOutOfRangeException("The value must be an integer greater than or equal to zero."); 
            }else if (n == 0) {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fib(n-1)+Fib(n-2);
            }
        }
    }
}
