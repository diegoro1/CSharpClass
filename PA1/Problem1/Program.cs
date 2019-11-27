using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputString;
            int input, encryptedValue, decrytedValue;

            Console.WriteLine("Enter Data To Be incrypted: ");
            inputString = Console.ReadLine();
            input = Convert.ToInt32(inputString);
            Console.WriteLine("Your input: " + input);

            encryptedValue = Encrypt(input);
            Console.WriteLine("Your value Encrypted: " + encryptedValue);

            decrytedValue = Decrypt(encryptedValue);
            Console.WriteLine("Your value Decrypted: " + decrytedValue);

            // testing out more random solution I came up with
            Console.WriteLine("Odd encrypt: " + OddEncrypt(input));
            Console.WriteLine("Odd encrypt: " + OddDecrypt(input));


        }

        private static int Encrypt(int given)
        {
            int first, second, third, forth, result;

            forth = given % 10;
            third = (given % 100) / 10; 
            second = (given % 1000) / 100;
            first = given / 1000;

            first = (first + 7) % 10;
            second = (second + 7) % 10;
            third = (third + 7) % 10;
            forth = (forth + 7) % 10;

            // swaps 1st with 3rd, 2nd with 4th
            result = (third * 1000) + (forth * 100) + (first * 10) + second;

            return result;
        }

        private static int Decrypt(int given)
        {
            int first, second, third, forth, result;

            forth = given % 10;
            third = (given % 100) / 10;
            second = (given % 1000) / 100;
            first = given / 1000;

            first = (first + 3) % 10;
            second = (second + 3) % 10;
            third = (third + 3) % 10;
            forth = (forth + 3) % 10;

            result = (third * 1000) + (forth * 100) + (first * 10) + second;

            return result;
        }

        // this one is something odd i thought about using arrays
        // above is a much cleaner solution

        private static int OddEncrypt(int given)
        {
            int first, second, third, forth, result = 0, i, j;
            int[] array = new int[4];

            forth = given % 10;
            third = (given % 100) / 10;
            second = (given % 1000) / 100;
            first = given / 1000;

            // swaps manually instead
            array[0] = (third + 7) % 10;
            array[1] = (forth + 7) % 10;
            array[2] = (first + 7) % 10;
            array[3] = (second + 7) % 10;

            // uses pow starting at 10^3(1000) to start adding the result
            // j decreases to ensure the correct position of int
            // since pow returns a double, convert is used since result is a int
            j = 3;
            for (i = 0; i < 4; i++)
            {
                result += array[i] * Convert.ToInt32(Math.Pow(10, j--));
            }


            return result;
        }

        private static int OddDecrypt(int given)
        {
            int first, second, third, forth, result = 0, i, j;
            int[] array = new int[4];

            forth = given % 10;
            third = (given % 100) / 10;
            second = (given % 1000) / 100;
            first = given / 1000;

            array[0] = (third + 3) % 10;
            array[1] = (forth + 3) % 10;
            array[2] = (first + 3) % 10;
            array[3] = (second + 3) % 10;

            j = 3;
            for (i = 0; i < 4; i++)
            {
                result += array[i] * Convert.ToInt32(Math.Pow(10, j--));
            }


            return result;
        }

    }
}
