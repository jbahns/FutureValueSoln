﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureValue.Models
{
    public class FutureValue
    {
        public decimal MonthlyInvestment { get; set; }
        public decimal YearlyInterestRate { get; set; }
        public int Years { get; set; }

        public decimal CalculatedFutureValue()
        {
            var months = Years * 12;
            var monthlyInterestRate = YearlyInterestRate / 12 / 100;
            var futureValue = 0m;
            for(var i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
