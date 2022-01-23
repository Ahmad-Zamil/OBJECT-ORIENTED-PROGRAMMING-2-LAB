using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, sum = 0;


            for (int i = 0; i <= 0; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("Enter the Input " + j + " : ");
                    input = Convert.ToInt32(Console.ReadLine());
                    sum += input;

                }

            }

            sum = sum / 5;
            Console.WriteLine("The Average of 5 number : " + sum);

            Console.ReadLine();

        }
    }
}
