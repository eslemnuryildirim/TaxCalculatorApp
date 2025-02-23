﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculatorApp.Strategies
{
    namespace TaxCalculatorApp.Strategies
    {
        public class USATax : ITaxCalculator
        {
            public decimal CalculateTax(decimal amount)
            {
                return amount * 0.07m;
            }
        }
    }

}
