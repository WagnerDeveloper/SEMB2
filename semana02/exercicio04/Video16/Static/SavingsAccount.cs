using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Static
{
    public class SavingsAccount
    {
        public static double currInterestRate;
        public static double bondRate = 0.0;

        static SavingsAccount(){
            currInterestRate = 0.4;
        }
        public static void AddBondRate(){
            currInterestRate = bondRate + 0.1;
        }
    }
}