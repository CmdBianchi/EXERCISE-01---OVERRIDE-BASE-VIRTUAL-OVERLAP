using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_01___OVERRIDE_BASE__VIRTUAL_OVERLAP.ENTITIES {
    //------------------------------- START -------------------------------//
    class BusinessAccount : Account {
        public double LoanLimit { get; set; }
        //------------------------------- CONST -------------------------------//  
        public BusinessAccount() {
        }
        //------------------------------- MET --------------------------------//
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) {
            LoanLimit = loanLimit;
        }
        public void Loan(double amount) {
            if (amount <= LoanLimit) {
                Balance += amount;
            }
        }
    }
    //-------------------------------- END -------------------------------//
}
