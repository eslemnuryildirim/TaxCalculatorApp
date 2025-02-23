using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculatorApp.Strategies
{
    public class TaxContext
    {
        private ITaxCalculator _taxCalculator;

        public void SetTaxStrategy(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public decimal CalculateTax(decimal amount)
        {
            return _taxCalculator.CalculateTax(amount);
        }
    }
}

