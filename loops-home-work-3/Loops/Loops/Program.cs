using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 1
            // I used short because I don't need such a large scope.
            WriteTaskNumber(1);

            short quantityPrimeNumbers = 0;
            for (short i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (short j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    quantityPrimeNumbers++;
                }
            }

            Console.WriteLine($"Quantity of the prime numbers is: {quantityPrimeNumbers}");

            KeepGoing();


            //Task 2
            WriteTaskNumber(2);

            short counter = 0;
            short iterator = 0;

            do
            {
                if (counter % 2 == 0 && counter != 0)
                {
                    iterator++;
                }
                counter++;
            } while (counter != 1000);

            Console.WriteLine($"Quantity of even numbers is: {iterator}");

            KeepGoing();

            //Task3
            WriteTaskNumber(3);

            int lenght = 1000;
            BigInteger[] arrayForFibonnaciNumbers = new BigInteger[lenght];
            arrayForFibonnaciNumbers[0] = 0;
            arrayForFibonnaciNumbers[1] = 1;

            for (int i = 2; i < 999; i++)
            {
                arrayForFibonnaciNumbers[i] = arrayForFibonnaciNumbers[i - 1] + arrayForFibonnaciNumbers[i - 2];
            }
            for (int i = 0; i < arrayForFibonnaciNumbers.Length; i++)
            {
                Console.WriteLine($"{arrayForFibonnaciNumbers[i]}");
            }

            KeepGoing();


            //Task 4
            WriteTaskNumber(4);

            int helper = 1;
            int helper2 = 1;

            Console.WriteLine("Enter your number: ");
            bool loading = int.TryParse(Console.ReadLine(), out int userNumber);

            if (loading)
            {
                for (int i = 1; i < userNumber; i++)
                {

                    Console.Write(i + " ");
                    if (helper == helper2)
                    {
                        Console.WriteLine();
                        helper2 = 0;
                        helper++;
                    }
                    helper2++;
                }
            }
            else
            {
                Console.WriteLine("Data is incorrect");
            }

            KeepGoing();

            //Task 5
            WriteTaskNumber(5);

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"The third power of a number {i} is: {Math.Pow(i, 3)}");
            }

            KeepGoing();

            //Task 6
            WriteTaskNumber(6);
            double sumNumber = 1.0;
            for (int i = 2; i < 21; i++)
            {
                Console.WriteLine($"Sum numbers {sumNumber} and 1/{i} = {sumNumber + (1.0 / (double)i)} ");
                sumNumber = sumNumber + (1.0 / i);
            }
            Console.WriteLine($"The sum of all numbers is: {sumNumber}");
            KeepGoing();

            //Task 7
            WriteTaskNumber(7);

            int smallerDiamondBase = 22;
            int numeberOfSpacious = 1;

            var bottomOfTheDiamond = new StringBuilder();
            var topOfTheDiamond = new StringBuilder();

            for (int i = smallerDiamondBase; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    bottomOfTheDiamond.Append('*', i);
                    bottomOfTheDiamond.Insert(bottomOfTheDiamond.Length, '\n');
                    bottomOfTheDiamond.Append(' ', numeberOfSpacious);
                    numeberOfSpacious++;
                }
            }

            if (smallerDiamondBase % 2 == 0)
            {
                smallerDiamondBase = smallerDiamondBase - 1;
            }

            for (int i = 1; i < smallerDiamondBase; i++)
            {
                if (i % 2 != 0)
                {
                    topOfTheDiamond.Append(' ', numeberOfSpacious - 2);
                    topOfTheDiamond.Append('*', i);
                    topOfTheDiamond.Append('\n', 1);
                    numeberOfSpacious--;
                }

            }
            Console.WriteLine(topOfTheDiamond.Insert(topOfTheDiamond.Length, bottomOfTheDiamond));

            KeepGoing();

            //Task 8
            WriteTaskNumber(8);

            string exampleString = "c d e f g a h c";

            for (int i = exampleString.Length; i > 0; i--)
            {
                Console.Write(exampleString[i - 1]);
            }

            KeepGoing();

            //Task 9
            WriteTaskNumber(9);

            int decimalNumber = 21;
            var binaryNumber = new StringBuilder();

            while (decimalNumber != 0)
            {
                binaryNumber.Insert(0, decimalNumber % 2);
                decimalNumber = decimalNumber / 2;
            }
            Console.WriteLine("Binary number: " + binaryNumber);

            KeepGoing();

            //Task 10
            int numberOne = 24;
            int numberTwo = 36;

            Console.WriteLine($"nnw = {numberOne/NWD(numberOne,numberTwo)*numberTwo}");
            Console.WriteLine("Thank you for atention!");

        }
        public static int NWD(int numberOne, int numberTwo)
        {
            int helper;
            while (numberTwo != 0)
            {
                helper = numberTwo;
                numberTwo = numberOne % numberTwo;
                numberOne = helper;
            }
            return numberOne;
        }
        public static void KeepGoing()
        {
            Console.WriteLine("\n If yout want to see next exercise press any key...");
            Console.ReadKey();
            Console.Clear();
        }
    
        public static void WriteTaskNumber(int taskNumber)
        {
            Console.WriteLine($"Task {taskNumber}");
        }
    }
}