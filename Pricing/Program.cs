using System;

namespace Pricing
{
    class Program
    {
        static void Main(string[] args)
        {
            var terminal = new PointOfSaleTerminal();
            terminal.setPricing();
            Console.WriteLine("Enter your product");
            string enterString = Console.ReadLine();
            terminal.ScanProduct(enterString);
            terminal.CalculateTotal();

        }
    }
}
