using System;
using System.Collections.Generic;
using EXERCISE_01___OVERRIDE_BASE__VIRTUAL_OVERLAP.ENTITIES;
namespace EXERCISE_01___OVERRIDE_BASE__VIRTUAL_OVERLAP {
    //-----> START
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            List<Account> list = new List<Account>();
            list.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500, 0.01));

            double sum = 0.0;
            foreach(Account acc in list) {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2"));
            foreach (Account acc in list) {
                acc.Withdraw(10.0);
            }
            foreach(Account acc in list) {
                Console.WriteLine("Updated balance for account " + acc.Number+":"+acc.Balance.ToString("F2"));
            }

        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
