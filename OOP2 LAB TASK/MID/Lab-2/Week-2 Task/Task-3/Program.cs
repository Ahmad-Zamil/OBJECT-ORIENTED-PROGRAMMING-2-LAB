using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Angel Value ");
            int angel1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Angel Value ");
            int angel2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Angel Value ");
            int angel3 = Convert.ToInt32(Console.ReadLine());

            double result = angel1 + angel2 + angel3;
            Console.WriteLine("Total Angel " + result);


            if (result > 180)
            {
                Console.WriteLine("Triangle can formed by the given value for the angel");
            }
            else
            {
                Console.WriteLine("Triangle can't formed by the given value for the angel");

            }
            Console.ReadKey();

        }
    }
}
