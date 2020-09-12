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
            Console.WriteLine("Task 1");

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

            Console.WriteLine("If yout want to see next question press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 2
            Console.WriteLine("Task 2");

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

            Console.WriteLine("If yout want to see next question press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task3
            Console.WriteLine("Task 3");

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

            Console.WriteLine("If yout want to see next question press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 4
            Console.WriteLine("Task 4");

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

            Console.WriteLine("If yout want to see next question press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 5
            Console.WriteLine("Task 5");

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

            Console.WriteLine("If yout want to see next question press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 6
            Console.WriteLine("Task 6");
            string exampleString = "c d e f g a h c";

            for (int i = exampleString.Length; i > 0; i--)
            {
                Console.Write(exampleString[i-1]);
            }

        }
    }
}