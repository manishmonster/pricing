using System;
using System.Collections.Generic;
using System.Text;

namespace Pricing
{
    class Price
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal BulkPrice { get; set; }
        public int BulkQuantity { get; set; }

        public Price()
        {
            Name = "";
            UnitPrice = 0.00M;
            BulkPrice = 0.00M;
            BulkQuantity = 0;
        }
        public Price(string enterName, decimal enteredUnitPrice, decimal enteredBulkPrice = 0.00M, int enteredBulkQunatity = 0)
        {
            Name = enterName;
            UnitPrice = enteredUnitPrice;
            BulkPrice = enteredBulkPrice;
            BulkQuantity = enteredBulkQunatity;
        }
    }
}
