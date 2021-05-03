﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyExample
{
    public class Money
    {
        protected internal int amount;

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount;
        }
    }
}