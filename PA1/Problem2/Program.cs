using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            double bmi = 0;

            Console.WriteLine("Please Select the Unit of Mesurent You'll Be Using:");
            Console.WriteLine("1-> Kilograms");
            Console.WriteLine("2-> Pound");

            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose: " + option);
            if (option != 1 && option != 2)
                System.Environment.Exit(0);

            switch (option)
            {
                case 1:
                    bmi = KgBmi();
                    break;

                case 2:
                    bmi = PdBmi();
                    break;
            }

            Console.WriteLine(string.Format("Your BMI: {0:0.00}", bmi));
            if (bmi < 18.5)
                Console.WriteLine("You are currently underweight.");
            else if (bmi >= 18.5 && bmi <= 24.9)
                Console.WriteLine("You are currently in normal weight.");
            else if (bmi >= 25 && bmi <= 29.9)
                Console.WriteLine("You are currently overweight");
            else
                Console.WriteLine("You are currently Obese");
        }

        private static double KgBmi()
        {
            double weight, height, bmi;

            Console.WriteLine("Please enter your weight in kg:");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your height in meters: ");
            height = Convert.ToDouble(Console.ReadLine());

            bmi = (weight) / (Math.Pow(height, 2));

            return bmi;
        }

        private static double PdBmi()
        {
            double weight, height, bmi;

            Console.WriteLine("Please enter your weight in pounds:");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your height in inches: ");
            height = Convert.ToDouble(Console.ReadLine());

            bmi = 703 * (weight) / (Math.Pow(height, 2));

            return bmi;
        }
    }
}
