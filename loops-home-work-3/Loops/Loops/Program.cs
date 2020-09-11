using System;
using System.Collections.Generic;
using System.Numerics;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 1
            // I used short because I don't need such a large scope.
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

            //Task 2
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

            //Task3
            int x = 1;
            int firstWord = 0;
            int secondWord = 1;
            int lenght = 1000;

            BigInteger[] tab = new BigInteger[lenght];
            tab[0] = 0;
            tab[1] = 1;
            for (int i = 2; i < 999; i++)
            {
                tab[i] = tab[i - 1] + tab[i - 2];
            }
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine($"{tab[i]}");
            }
        }
    }
}
