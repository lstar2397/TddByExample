using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyExample
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {

        }

        public override Money Times(int multiplier)
        {
            return Dollar(amount * multiplier);
        }
    }
}
