using System;
using System.Collections.Generic;
using System.Text;

namespace Pricing
{
    interface ISaleTerminal
    {
        void setPricing();
        void ScanProduct(string text);
        void CalculateTotal();
    }
    
}
