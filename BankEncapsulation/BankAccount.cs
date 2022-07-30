﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public void Deposit(double deposit)
        {
            balance += deposit;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
