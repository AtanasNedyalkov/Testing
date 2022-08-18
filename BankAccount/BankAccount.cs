using System;

namespace Test
{
    public class BankAccount
    {
        public decimal Amount { get; protected set; }

        public BankAccount(decimal amount)
        {
            this.Amount = amount;
        }
    }
}
