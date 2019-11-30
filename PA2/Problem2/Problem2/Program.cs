using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            SavingsAccount saver1 = new SavingsAccount(4, 2000.00);
            SavingsAccount saver2 = new SavingsAccount(4, 3000.00);

            for (i = 0; i < 12; i++)
            {
                Console.WriteLine(string.Format("Month ({0})", i+1));
                saver1.calculateMonthlyInterest();
                saver2.calculateMonthlyInterest();
                Console.WriteLine(string.Format("saver1 balance: {0:0.00}", saver1.GetSavingsBalance()));
                Console.WriteLine(string.Format("saver1 balance: {0:0.00}", saver2.GetSavingsBalance()));
            }

            saver1.modifyInterestRate(5);
            saver2.modifyInterestRate(5);

            Console.WriteLine("----------------------------------");

            for (i = 0; i < 12; i++)
            {
                Console.WriteLine(string.Format("Month ({0})", i+1));
                saver1.calculateMonthlyInterest();
                saver2.calculateMonthlyInterest();
                Console.WriteLine(string.Format("saver1 balance: {0:0.00}", saver1.GetSavingsBalance()));
                Console.WriteLine(string.Format("saver1 balance: {0:0.00}", saver2.GetSavingsBalance()));
            }

        }
    }
}
