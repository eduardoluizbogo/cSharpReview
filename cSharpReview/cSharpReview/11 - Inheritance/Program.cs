using cSharpReview._11___Inheritance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview._11___Inheritance
{
    internal class Program
    {
        public static void Main1(string[] args)
        {

            Account account1 = new Account(1001, "Alex", 50.0);
            Account account2 = new SavingsAccount(1004, "Anna", 50.0, 0.01);

            account1.Withdraw(5);
            account2.Withdraw(5);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);






            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            ////UPCASTING
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);


            ////DOWNCASTING

            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.0);

            ////BusinessAccount acc5 = (BusinessAccount)acc3; // error because acc3 is not an instance of BusinessAccount

            //if(acc3 is BusinessAccount)
            //{
            //    //BusinessAccount acc6 = (BusinessAccount)acc3;
            //    BusinessAccount acc6 = acc3 as BusinessAccount;
            //    acc6.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}

            //if(acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc6 = (SavingsAccount)acc3;
            //    SavingsAccount acc6 = acc3 as SavingsAccount;
            //    acc6.UpdateBalance();
            //    Console.WriteLine("Update");
            //}

        }
    }
}
