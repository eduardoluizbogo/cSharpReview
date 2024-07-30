using cSharpReview._18___ExceptionExcercice.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview._18___ExceptionExcercice.Entities
{
    internal class Account1
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account1(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance =+ amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
                throw new DomainException1("Balance not enough");

            if (amount > WithdrawLimit)
                throw new DomainException1("More than allowed");

            Balance -= amount;
        }
    }
}
