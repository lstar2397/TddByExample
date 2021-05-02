﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyExample
{
    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public void Times(int multiplier)
        {
            amount *= multiplier;
        }
    }
}
