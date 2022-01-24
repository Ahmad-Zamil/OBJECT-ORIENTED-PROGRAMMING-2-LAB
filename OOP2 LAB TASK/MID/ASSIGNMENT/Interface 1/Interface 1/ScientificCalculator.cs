using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class ScientificCalculator : BasicCalculatorInterface,ScientificCalculatrorInterface
    {
        public int division(int a, int b)
        {
            Console.Write("division  {0} and {1} is  ", a, b);
            return a / b;
        }

        public int multiplication(int a, int b)
        {
            Console.Write("multiplication {0} and {1} is  ", a, b);
            return a * b;
        }

        public int sub(int a, int b)
        {
            Console.Write("sub {0} and {1} is  ", a, b);
            return a - b;
        }

        public int sum(int a, int b)
        {
            Console.Write("sum {0} and {1} is  ", a, b);
            return a + b;
        }

        public double root(int a)
        {
            Console.Write("root {0} is    ", a);
            return Math.Sqrt(a);
        }

        public int square(int a)
        {
            Console.Write("square {0}  is  ", a);
            return a * a;
        }

        public int XtoY(int a, int b)
        {
            Console.Write("a^b {0}  is   ", a);
            return b;
        }
    }
}
