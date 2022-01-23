using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                   Console.WriteLine("Enter Total Marks ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 90)
            {
                Console.WriteLine("Your Result is A+");

            }

            else if (number >=80 && number <= 90)
            {
                Console.WriteLine("Your Result is A");

            }

            else if (number >= 70 && number <= 80)
            {
                Console.WriteLine("Your Result is B");

            }

            else if (number >= 60 && number <= 70)
            {
                Console.WriteLine("Your Result is C");

            }
            else if (number >= 50 && number <= 60)
            {
                Console.WriteLine("Your Result is D");

            }
                else if (number <50)
                {
                    Console.WriteLine("Your Result is F");

                }

            Console.ReadKey();

                   
               

            }
        }
    }
}
