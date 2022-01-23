using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number ");
            int number = Convert.ToInt32(Console.ReadLine());

            int x;
            for (int i = 1; i <= 10; i++)
            {
                x = number * i;
                Console.WriteLine(number + " multiplication " + i + " = " + x);
            }

            Console.ReadLine();


        }
    }
}
