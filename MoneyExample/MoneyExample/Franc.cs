using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyExample
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {

        }

        public override Money Times(int multiplier)
        {
            return Franc(amount * multiplier);
        }
    }
}
