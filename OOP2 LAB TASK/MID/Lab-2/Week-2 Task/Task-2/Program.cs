using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product Price  ");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Quantity  ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Tax on your Purespective Product   ");
            int tax = Convert.ToInt32(Console.ReadLine());

            double PriceWithoutTax = price * quantity;
            double TaxValue = (PriceWithoutTax * tax) / 100;
            double Price = PriceWithoutTax + TaxValue;



            Console.WriteLine("After Include the Vat,the price  " + Price);
            Console.ReadKey();

        }
    }
}
