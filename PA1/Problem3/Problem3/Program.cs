using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 1;

            string[] topics = new string[5];
            topics[0] = "Dog food";
            topics[1] = "Cat food";
            topics[2] = "human food";
            topics[3] = "politics";
            topics[4] = "nothing at all";

            int[,] responses = new int[11, 5]
                { {1, 2, 3, 4, 5 },
                  {0, 0, 0, 0, 0 },
                  {0, 0, 0, 0, 0 },
                  {0, 0, 0, 0, 0 },
                  {0, 0, 0, 0, 0 },
                  {0, 0, 0, 0, 0 },
                  {0, 0, 0, 0, 0 },
                  {0, 0, 0, 0, 0 },
                  {0, 0, 0, 0, 0 },
                  {0, 0, 0, 0, 0 },
                  {0, 0, 0, 0, 0 }};

            Console.WriteLine("You will be shown 5 topics which you'll be rating.");
            Console.WriteLine("rate them from 1-10, 10 being the best! :) 1 the least great. :(");
            Console.WriteLine("");

            // will exit even to display even if '2' is not selected
            while (option == 1)
            {
                Rate(topics, responses);
                option = Menu();
            }

            DisplayResult(topics, responses);
        }

        // Displays menu and returns response
        private static int Menu()
        {
            Console.WriteLine("Select an Option:");
            Console.WriteLine("1-> New Rater");
            Console.WriteLine("2-> exit and show results");

            return Convert.ToInt32(Console.ReadLine());
        }


        // this gets the rating given by to the subject and adds the corresponding
        // array index
        private static void Rate(String[] topics, int[,] responses)
        {
            int i, rate;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Rate the topic: " + topics[i]);
                Console.WriteLine("Rate: ");
                rate = Convert.ToInt32(Console.ReadLine());

                if (rate < 1 || rate > 10)
                    System.Environment.Exit(0);

                responses[rate,i] += 1;
            }
        }


        // displays the results in a table format once user exits
        private static void DisplayResult(string[] topics, int[,] responses)
        {
            int i, j = 1;
            Console.WriteLine(string.Format("Topic Rate         \t| 1\t| 2\t| 3\t| 4\t| 5\t| 6 \t|" +
                " 7 \t| 8\t| 9\t| 10 \t|"));
            Console.WriteLine("------------------------|-------|-------|-------|-------|-------|--" +
                "-----|------|--------|-------|-------|");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(string.Format("{0}         \t| {1}\t| {2}\t| {3}\t| " +
                    "{4}\t| {5}\t| {6}\t| {7}\t| {8}\t| {9}\t| {10}\t|", topics[i], responses[j++, i],
                    responses[j++, i], responses[j++, i], responses[j++, i], responses[j++, i], responses[j++, i],
                    responses[j++, i], responses[j++, i], responses[j++, i], responses[j++, i]));
                j = 1;
            }
        }
    }
}
