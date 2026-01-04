using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPP.Polymorphism
{
    public class TaxCalculator
    {
        public virtual decimal CalculateTax(decimal amount) => amount * 0.1m; // Default 10%
    }

    public class UkTaxCalculator : TaxCalculator
    {
        public override decimal CalculateTax(decimal amount) => amount * 0.2m; // UK is 20%
    }
}