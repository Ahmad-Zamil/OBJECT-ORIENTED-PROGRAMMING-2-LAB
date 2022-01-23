using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Number Of Days ");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            int year = days / 365;
            int week = (days - (year * 365)) / 7;
            int day = days - ((year * 365) + (week * 7));
            Console.WriteLine("Years =  " + year);
            Console.WriteLine("weeks =  " + week);
            Console.WriteLine("Days =  " + day);

            Console.ReadKey();

        }
    }
}
