using System;

namespace StaticDateAndMembers
{
    class SavingAccount
    {
        private double currBalance;
        private static double _currInterestRate = 0.04;
        public SavingAccount(double balance)
        {
            currBalance = balance;
        }
        static SavingAccount()
        {
            Console.WriteLine("In static ctor!");
        }
        public static double InterestRate
        {
            get => _currInterestRate;
            set => _currInterestRate = value;
        }
    }
}
