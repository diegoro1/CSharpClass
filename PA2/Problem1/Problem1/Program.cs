using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int typeOfProblem, difficulty, i;
            double total, score;

            Random rand = new Random();

            Console.WriteLine("Welcome to the cool math app!");

            typeOfProblem = ProblemMenu();
            difficulty = DifficultyMenu();

            for (i = 0; i < 10; i++)
            {
                switch (typeOfProblem)
                {
                    case 1:
                        total = AdditionProblem(difficulty, rand);
                        break;

                    case 2:
                        total = MultiplicationProblem(difficulty, rand);
                        break;

                    case 3:
                        total = SubtractionProblem(difficulty, rand);
                        break;

                    case 4:
                        total = DivisionProblem(difficulty, rand);
                        break;

                    case 5:
                        total = RandomProblem(difficulty, rand);
                        break;
                }

            }

            // calculates %tage of student score
            score = (total / 10) * 100;

            if (score < 75)
                Console.WriteLine("Please ask your teacher for extra help.");
            else
                Console.WriteLine("Congratulations, you are ready to go to the next level!");

        }

        // used to build a simple UI returns the option given by user
        private static int ProblemMenu()
        {
            int option;
            Console.WriteLine("Please Select the Type of Problem:");
            Console.WriteLine("1 -> Addition");
            Console.WriteLine("2 -> Multiplication");
            Console.WriteLine("3 -> Subtraction");
            Console.WriteLine("4 -> Division");
            Console.WriteLine("5 -> Random");
            option = Convert.ToInt32(Console.ReadLine());

            if (option > 4 || option < 1)
                System.Environment.Exit(0);

            return option;
        }

        // used to build a simple UI returns the option given by user
        private static int DifficultyMenu()
        {
            int option;
            Console.WriteLine("Please Select a level(1 - 3):");
            option = Convert.ToInt32(Console.ReadLine());

            if (option > 3 || option < 1)
                System.Environment.Exit(0);

            return option;
        }


        // sets random int used in the math problems
        private static int SetRand(int difficulty, Random rand)
        {
            int value = 0;

            switch (difficulty)
            {
                case 1:
                    value = rand.Next(-9, 10);
                    break;
                case 2:
                    value = rand.Next(-99, 100);
                    break;
                case 3:
                    value = rand.Next(-999, 1000);
                    break;
            }

            return value;
        }

        // displays a random positive message to the user
        private static void PositiveAnswer(Random rand)
        {
            int answer = rand.Next(1, 5);

            switch (answer)
            {
                case 1:
                    Console.WriteLine("Very good!");
                    break;

                case 2:
                    Console.WriteLine("Excellent!");
                    break;

                case 3:
                    Console.WriteLine("Nice work!");
                    break;

                case 4:
                    Console.WriteLine("Keep up the good work!");
                    break;
            }
        }

        // displays a random negative message to the user
        private static void NegativeAnswer(Random rand)
        {
            int answer = rand.Next(1, 5);

            switch (answer)
            {
                case 1:
                    Console.WriteLine("No. Please try again.");
                    break;

                case 2:
                    Console.WriteLine("Wrong. Try once more.");
                    break;

                case 3:
                    Console.WriteLine("Don’t give up!");
                    break;

                case 4:
                    Console.WriteLine("No. Keep trying.");
                    break;
            }
        }


        // formulates an addition problem returs 1 if user gives correct answer
        // 0 if not
        private static int AdditionProblem(int difficulty, Random rand)
        {
            int firstVal, secondVal, answer, userAsnwer;

            firstVal = SetRand(difficulty, rand);
            secondVal = SetRand(difficulty, rand);

            answer = firstVal + secondVal;

            Console.WriteLine(firstVal + " + " + secondVal + " = ?");
            userAsnwer = Convert.ToInt32(Console.ReadLine());

            if (userAsnwer == answer)
            {
                PositiveAnswer(rand);
                return 1;
            }
            else
            {
                NegativeAnswer(rand);
                return 0;
            }
        }

        // formulates a multiplication problem returs 1 if user gives correct answer
        // 0 if not
        private static int MultiplicationProblem(int difficulty, Random rand)
        {
            int firstVal, secondVal, answer, userAsnwer;

            firstVal = SetRand(difficulty, rand);
            secondVal = SetRand(difficulty, rand);

            answer = firstVal * secondVal;

            Console.WriteLine(firstVal + " * " + secondVal + " = ?");
            userAsnwer = Convert.ToInt32(Console.ReadLine());

            if (userAsnwer == answer)
            {
                PositiveAnswer(rand);
                return 1;
            }
            else
            {
                NegativeAnswer(rand);
                return 0;
            }
        }

        // formulates a subtration problem returs 1 if user gives correct answer
        // 0 if not
        private static int SubtractionProblem(int difficulty, Random rand)
        {
            int firstVal, secondVal, answer, userAsnwer;

            firstVal = SetRand(difficulty, rand);
            secondVal = SetRand(difficulty, rand);

            answer = firstVal - secondVal;

            Console.WriteLine(firstVal + " - " + secondVal + " = ?");
            userAsnwer = Convert.ToInt32(Console.ReadLine());

            if (userAsnwer == answer)
            {
                PositiveAnswer(rand);
                return 1;
            }
            else
            {
                NegativeAnswer(rand);
                return 0;
            }
        }

        // formulates a division problem with no remainders returs 1 if user gives correct answer
        // 0 if not 
        private static int DivisionProblem(int difficulty, Random rand)
        {
            int firstVal, secondVal, answer, userAsnwer;

            firstVal = SetRand(difficulty, rand);
            secondVal = SetRand(difficulty, rand);

            // makes sure no number is devided by 0 or 0/0 occurs
            // also avoids divisions with remainders
            while ((firstVal % secondVal != 0) && (firstVal == 0 && secondVal == 0) && (firstVal == 0))
            {
                firstVal = SetRand(difficulty, rand);
                secondVal = SetRand(difficulty, rand);
            }

            answer = firstVal / secondVal;

            Console.WriteLine(firstVal + " / " + secondVal + " = ?");
            userAsnwer = Convert.ToInt32(Console.ReadLine());

            if (userAsnwer == answer)
            {
                PositiveAnswer(rand);
                return 1;
            }
            else
            {
                NegativeAnswer(rand);
                return 0;
            }
        }

        // formulates a random problem calling other math functios returs what other fuctions dictate
        // will return -9999999 if fails
        private static int RandomProblem(int difficulty, Random rand)
        {
            int randomProblem = rand.Next(1, 5);
            switch (randomProblem)
            {
                case 1:
                    return AdditionProblem(difficulty, rand);

                case 2:
                    return MultiplicationProblem(difficulty, rand);

                case 3:
                    return SubtractionProblem(difficulty, rand);

                case 4:
                    return DivisionProblem(difficulty, rand);
            }

            return -9999999;
        }
    }
}
