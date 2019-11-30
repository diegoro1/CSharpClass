using System;
namespace Problem2
{
    public class SavingsAccount
    {
        private double annualInterestRate;
        private double savingsBalance;

        public SavingsAccount(double _annualInterestRate, double _savingsBalance)
        {
            annualInterestRate = _annualInterestRate;
            savingsBalance = _savingsBalance;
        }

        public void calculateMonthlyInterest()
        {
            savingsBalance += savingsBalance * annualInterestRate / 12.0;
        }

        public void modifyInterestRate(double newInterestRate)
        {
            annualInterestRate = newInterestRate;
        }

        public double GetSavingsBalance()
        {
            return savingsBalance;
        }
    }
}
