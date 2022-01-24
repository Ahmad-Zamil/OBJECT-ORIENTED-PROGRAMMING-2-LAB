using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class BasicCalculator : BasicCalculatorInterface
    {

      
        public int division(int a, int b)
        {
            Console.Write("The division of {0} and {1} is  ", a, b);
            return a / b;
        }

        public int multiplication(int a, int b)
        {
            Console.Write("The mul of {0} and {1} is  ", a, b);
            return a * b;
        }

        public int sub(int a, int b)
        {
            Console.Write("The sub of {0} and {1} is  ", a, b);
            return a - b;
        }

        public int sum(int a, int b)
        {
            Console.Write("The sum of {0} and {1} is  ",a,b);
            return a + b;
        }
    }
}
