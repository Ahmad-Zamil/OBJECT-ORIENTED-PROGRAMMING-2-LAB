using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator basicCalculator = new BasicCalculator();
            Console.WriteLine("Basic Calculator Functionality\n\n");
            Console.WriteLine(basicCalculator.sum(20, 15));
            Console.WriteLine(basicCalculator.sub(20, 12));
            Console.WriteLine(basicCalculator.multiplication(15, 10));
            Console.WriteLine(basicCalculator.division(20,15));
            Console.WriteLine("\n");

            ScientificCalculator scientificCalculator = new ScientificCalculator();
            Console.WriteLine("Scientific Calculator Functionality\n\n");
            Console.WriteLine(scientificCalculator.root(225));
            Console.WriteLine(scientificCalculator.square(33));
            Console.WriteLine(scientificCalculator.sub(25, 30));
            Console.WriteLine(scientificCalculator.multiplication(25, 20));
          //  Console.WriteLine(scientificCalculator.XtoY(12,22));
            Console.ReadLine();


        }
    }
}
