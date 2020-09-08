using System;

namespace conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Task 1
            Console.WriteLine("Task 1");
            int firstNumber = 5;
            int secondNumber = 5;

            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"{firstNumber} and {secondNumber} are equal");
            }
            else
            {
                Console.WriteLine($"{firstNumber} and {secondNumber} aren't equal");
            }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 2
            Console.WriteLine("Task 2");
            Console.WriteLine("Give me a number");

            double number;

            if (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Data is incorrect");
            }
            else
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is even.");
                }
                else if (number % 2 != 0)
                {
                    Console.WriteLine($"{number} isn't even.");
                }
            }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 3
            Console.WriteLine("Task 3");
            Console.WriteLine("Give me a number");

            if (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Data is incorrect");
            }
            else
            {
                if (number > 0)
                {
                    Console.WriteLine($"{number} is positvie.");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"{number} is negative.");
                }
                else
                {
                    Console.WriteLine($"{number} is zero!");
                }
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();
            //Task 4
            Console.WriteLine("Task 4");
            Console.WriteLine("Give me a year");

            int yearFromUser;

            if (!int.TryParse(Console.ReadLine(), out yearFromUser) || yearFromUser <= 0)
            {
                Console.WriteLine("Year is incorrect");
            }
            else
            {
                DateTime year = new DateTime(yearFromUser, 1, 1);

                if (DateTime.IsLeapYear(year.Year) == true)
                {
                    Console.WriteLine($"{yearFromUser} is leap");
                }
                else
                {
                    Console.WriteLine($"{yearFromUser} isn't leap");
                }
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();
            //Task 5
            Console.WriteLine("Task 5");
            Console.WriteLine("Give me your age!");

            int age;
            if (int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                if (age > 0 && age < 21) Console.WriteLine("You cannot be president, MP, prime minister and senator.");
                else if (age >= 21 && age < 30) Console.WriteLine("You can be only MP and prime minister");
                else if (age >= 30 && age < 35) Console.WriteLine("You can be MP, prime minister and senator");
                else if (age >= 35) Console.WriteLine("You can be president, MP, prime minister and senator");
            }
            else
            {
                Console.WriteLine("Data is incorrect");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();
            //task 6

            Console.WriteLine("Enter your height!");

            int height;
            if (int.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                if (height < 50) Console.WriteLine("You are little mouse!");
                else if (height >= 50 && height < 75) Console.WriteLine("You are a little bit bigger mouse");
                else if (height >= 75 && height < 100) Console.WriteLine("You are a little rat!");
                else if (height >= 100 && height < 125) Console.WriteLine("You are a little bit bigger rat");
                else if (height >= 125 && height < 150) Console.WriteLine("you are a little cat");
                else if (height >= 150 && height < 175) Console.WriteLine("You are a little bit bigger cat");
                else if (height >= 175 && height < 200) Console.WriteLine("You are a little monster");
                else if (height >= 200 && height < 225) Console.WriteLine("You are a little bit bigger monster");
                else if (height > 225) Console.WriteLine("You are really big MONSTER!");
            }
            else
            {
                Console.WriteLine("Data is incorrect");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 7

            Console.WriteLine("Task 7");
            Console.WriteLine("Number one");
            int numberOne;
            bool loadingOne = int.TryParse(Console.ReadLine(), out numberOne);

            Console.WriteLine("Number two");
            int numberTwo;
            bool loadingTwo = int.TryParse(Console.ReadLine(), out numberTwo);

            Console.WriteLine("Number three");
            int numberThree;
            bool loadingThree = int.TryParse(Console.ReadLine(), out numberThree);

            if (loadingOne && loadingTwo && loadingThree)
            {
                if (numberOne > numberTwo && numberOne > numberThree)
                {
                    Console.WriteLine($"The largest number is {numberOne}");
                }
                else if (numberTwo > numberOne && numberTwo > numberThree)
                {
                    Console.WriteLine($"The largest number is {numberTwo}");
                }
                else
                {
                    Console.WriteLine($"The largest number is {numberThree}");
                }
            }
            else
            {
                Console.WriteLine("Data is incorrect!");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 8

            Console.WriteLine("Task 8");

            int resultMathAndPhysicsExamScores;
            int resultMathAndChemistryExamScores;
            int resultMathAndPhysicsAndChemistryExamScores;


            Console.WriteLine("Enter your math exam score!");
            loadingOne = int.TryParse(Console.ReadLine(), out int mathExamScore);

            Console.WriteLine("Enter your physics exam score!");
            loadingTwo = int.TryParse(Console.ReadLine(), out int physicsExamScore);

            Console.WriteLine("Enter your chemistry exam score!");
            loadingThree = int.TryParse(Console.ReadLine(), out int chemistryExamScore);

            resultMathAndPhysicsExamScores = mathExamScore + physicsExamScore;
            resultMathAndChemistryExamScores = mathExamScore + chemistryExamScore;
            resultMathAndPhysicsAndChemistryExamScores = mathExamScore + physicsExamScore + chemistryExamScore;

            if (loadingOne && loadingTwo && loadingThree)
            {
                bool conditionHelper = mathExamScore > 70 && physicsExamScore > 55 && chemistryExamScore > 45;
                if (conditionHelper && resultMathAndPhysicsAndChemistryExamScores > 180 ||
                    conditionHelper && resultMathAndPhysicsExamScores > 150 && mathExamScore > 70 ||
                    conditionHelper && resultMathAndChemistryExamScores > 150 && mathExamScore > 70)
                {
                    Console.WriteLine("congratulation");
                }
                else
                {
                    Console.WriteLine("Life is brutal");
                }
            }
            else
            {
                Console.WriteLine("Data is incorrect!");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 9

            Console.WriteLine("Enter your temperature!");
            bool temperatureReading = int.TryParse(Console.ReadLine(), out int temperature);

            if (temperatureReading)
            {
                if (temperature < 0) Console.WriteLine("Cholernie piździ!");
                else if (temperature >= 0 && temperature < 10) Console.WriteLine("zimno");
                else if (temperature >= 10 && temperature < 20) Console.WriteLine("chłodno");
                else if (temperature >= 20 && temperature < 30) Console.WriteLine("w sam raz");
                else if (temperature >= 30 && temperature < 40) Console.WriteLine("zaczyna być słabo, bo gorąco");
                else if (temperature >= 40) Console.WriteLine("a weź, wyprwoadzam się na analaskę");
            }
            else
            {
                Console.WriteLine("Data is incorrect!");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 10
            Console.WriteLine("Task 10");

            Console.WriteLine("Number one");
            loadingOne = int.TryParse(Console.ReadLine(), out int firstTriangleSide);

            Console.WriteLine("Number two");
            loadingTwo = int.TryParse(Console.ReadLine(), out int secondTriangleSide);

            Console.WriteLine("Numbert three");
            loadingThree = int.TryParse(Console.ReadLine(), out int thridTriangleSide);


            if (loadingOne && loadingTwo && loadingThree)
            {
                if (firstTriangleSide > secondTriangleSide && firstTriangleSide > thridTriangleSide)
                {
                    if (firstTriangleSide <= (secondTriangleSide + thridTriangleSide))
                    {
                        Console.WriteLine("You can build triangle");
                    }
                    else
                    {
                        Console.WriteLine("You can't build triangle");
                    }
                }
                else if (secondTriangleSide > firstTriangleSide && secondTriangleSide > thridTriangleSide)
                {
                    if (secondTriangleSide <= (firstTriangleSide + thridTriangleSide))
                    {
                        Console.WriteLine("You can build triangle");
                    }
                    else
                    {
                        Console.WriteLine("You can't build triangle");
                    }
                }
                else
                {
                    if (thridTriangleSide <= (secondTriangleSide + firstTriangleSide))
                    {
                        Console.WriteLine("You can build triangle");
                    }
                    else
                    {
                        Console.WriteLine("You can't build triangle");
                    }
                }
            }
            else
            {
                Console.WriteLine("Data is incorrect!");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 11
            Console.WriteLine("Task 11");

            Console.WriteLine("Enter rating!");

            loadingOne = int.TryParse(Console.ReadLine(), out int rating);

            if (loadingOne && rating > 0 && rating <= 6)
            {

                var ratings = rating switch
                {
                    1 => Ratings.Niedostateczny,
                    2 => Ratings.Dostateczny,
                    3 => Ratings.Dopuszczajacy,
                    4 => Ratings.Dobry,
                    5 => Ratings.BardzoDobry,
                    6 => Ratings.Celujacy
                };
                Console.WriteLine($"Your score is {ratings}");
            }
            else
            {
                Console.WriteLine("Data is incorrect");
            }


            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 12

            Console.WriteLine("Task 12");

            Console.WriteLine("Enter day!");

            loadingOne = int.TryParse(Console.ReadLine(), out int day);

            if (loadingOne && day > 0 && day <= 7)
            {

                var days = day switch
                {
                    1 => DaysOfTheWeek.Poniedzialek,
                    2 => DaysOfTheWeek.Wtorek,
                    3 => DaysOfTheWeek.Sroda,
                    4 => DaysOfTheWeek.Czwartek,
                    5 => DaysOfTheWeek.Piatek,
                    6 => DaysOfTheWeek.Sobota,
                    7 => DaysOfTheWeek.Niedziela
                };
                Console.WriteLine($"Your day is {days}");
            }
            else
            {
                Console.WriteLine("Data is incorrect");
            }


            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();

            //Task 13
            Console.WriteLine("Task 14");


            Console.WriteLine("Enter number one!");
            loadingTwo = double.TryParse(Console.ReadLine(), out double numberFirst);

            Console.WriteLine("Enter number Two!");
            loadingThree = double.TryParse(Console.ReadLine(), out double numberSecond);

            Console.WriteLine("Choose operation");
            Console.WriteLine(" 1. PLUS \n 2. MINUS \n 3. Multiply \n 4. DIVIDE");
            loadingOne = int.TryParse(Console.ReadLine(), out int operation);


            if (loadingOne && loadingTwo && loadingThree)
            {
                if (operation == 4 && numberSecond == 0)
                {
                    Console.WriteLine("Don't divide by zero");
                }
                else
                {
                    var result = Calculator(numberFirst, numberSecond, operation);
                    Console.WriteLine($"Result: {numberFirst} and {numberSecond} = {(double)result}");

                }
            }
            else
            {
                Console.WriteLine("Data is incorrect!");
            }
        }

        public static double Calculator(double a, double b, int operation)
        {
            switch (operation)
            {
                case 1:
                    {
                        return a + b;
                    }

                case 2:
                    {
                        return a - b;
                    }

                case 3:
                    {
                        return a * b;
                    }

                case 4:
                    {
                        return a / b;
                    }

                default:
                    {
                        return 0;
                    }
            }
        }

        public enum Ratings
        {
            Niedostateczny,
            Dopuszczajacy,
            Dostateczny,
            Dobry,
            BardzoDobry,
            Celujacy
        }

        public enum DaysOfTheWeek
        {
            Poniedzialek,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        }



    }
}

