using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_01___OVERRIDE_BASE__VIRTUAL_OVERLAP.ENTITIES {
    //------------------------------- START -------------------------------//
    class SavingsAccount : Account {
        public double Interesrate { get; set; }
    //------------------------------- CONST -------------------------------//  
        public SavingsAccount() {}

        public SavingsAccount(int number, string holder, double balance, double interesrate) : base(number, holder, balance) {
            Interesrate = interesrate;
        }
    //------------------------------- MET --------------------------------//
        public void UpdateBalance() {
            Balance += Balance * Interesrate;
        }
        public override void Withdraw(double amount) {
            Balance -= amount;
        }

    }
    //-------------------------------- END -------------------------------//
}
