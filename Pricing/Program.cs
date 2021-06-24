using System;

namespace Pricing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool closed = false;
            do
            {
                var terminal = new PointOfSaleTerminal();
                terminal.setPricing();
                Console.Write("Enter your product : ");
                string enterString = Console.ReadLine();
                terminal.ScanProduct(enterString);
                terminal.CalculateTotal();

                Console.Write("Do you want to contiune(\"Yes\"/\"No\") : ");
                string response = Console.ReadLine();
                if(response == "Yes" || response == "Y" || response == "yes")
                {
                    closed = true;
                }
                else
                {
                    closed = false;
                }
            }
            while (closed);

        }
    }
}
