using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculatorApp.Strategies
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(decimal amount);
    }
}
