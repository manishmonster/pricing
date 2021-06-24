using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pricing
{
    class PointOfSaleTerminal : ISaleTerminal
    {
        Dictionary<string, Price> pricedistory = new Dictionary<string, Price>();
        Dictionary<string, int> foundItemamount = new Dictionary<string, int>();
        bool productExist = false;

        public void setPricing()
        {
            pricedistory.Add("A", new Price() { Name = "A", UnitPrice = 1.25M, BulkQuantity = 3, BulkPrice = 3.00M });
            pricedistory.Add("B", new Price() { Name = "B", UnitPrice = 4.25M });
            pricedistory.Add("C", new Price() { Name = "C", UnitPrice = 1.00M, BulkQuantity = 6, BulkPrice = 5.00M });
            pricedistory.Add("D", new Price() { Name = "D", UnitPrice = 0.75M });
        }
        public void CalculateTotal()
        {
            decimal totalproduct = 0;
            if (!productExist)
            {
                Console.WriteLine("Some Products are not found");
            }
            else
            {
                for (int i = 0; i < foundItemamount.Count; i++)
                {
                    Price itemPrice = pricedistory[foundItemamount.ElementAt(i).Key];
                    int quantity = foundItemamount.ElementAt(i).Value;
                    int bulkQuantity = Int32.Parse(itemPrice.BulkQuantity.ToString());
                    if (bulkQuantity != 0 && quantity >= bulkQuantity)
                    {
                        decimal bulkprice = Decimal.Parse(itemPrice.BulkPrice.ToString());
                        decimal unitprice = Decimal.Parse(itemPrice.UnitPrice.ToString());
                        int remaining = quantity % bulkQuantity;
                        int bulk = quantity / bulkQuantity;

                        totalproduct = totalproduct + (bulkprice * bulk) + (unitprice * remaining);
                    }
                    else
                    {
                        decimal unitprice = Decimal.Parse(itemPrice.UnitPrice.ToString());
                        totalproduct = totalproduct + (unitprice * quantity);
                    }
                }
                Console.WriteLine("Total is : $" + totalproduct);
            }
        }

        public void ScanProduct(string text)
        {
            text = text.ToUpper();
            foreach (char ch in text)
            {
                if (pricedistory.ContainsKey(ch.ToString()) == false)
                {
                    productExist = false;
                    break;
                }
                else
                {
                    productExist = true;
                    if (foundItemamount.ContainsKey(ch.ToString()) == false)
                    {
                        foundItemamount.Add(ch.ToString(), 1);
                    }
                    else
                    {
                        foundItemamount[ch.ToString()] = foundItemamount[ch.ToString()] + 1;
                    }
                }
            }
        }
    }
}
