using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_01___OVERRIDE_BASE__VIRTUAL_OVERLAP.ENTITIES {
    //------------------------------- START -------------------------------//
    class SavingsAccount : Account  {
        public double InterestRate { get; set; }

        //------------------------------- CONST -------------------------------//  
        public SavingsAccount(){
        }

        //------------------------------- MET --------------------------------//
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
    //-------------------------------- END -------------------------------//
}
