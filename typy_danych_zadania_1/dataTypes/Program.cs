using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Threading.Tasks;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1.
            Console.WriteLine("Task 1");

            string name;
            string surname;
            int age;
            string pesel;
            Gender gender;
            int employeeId;

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //Task 2.
            Console.WriteLine("Task 2");

            char letterOne = 'a';
            char letterTwo = 'b';
            char letterThree = 'c';

            Console.WriteLine($"Letters: {letterThree}, {letterTwo}, {letterOne} \n");
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //Task 3.
            Console.WriteLine("Task 3");

            double widthRectangle;
            double lenghtRectangle;

            Console.WriteLine("Enter the width of the rectangle.");
            double.TryParse(Console.ReadLine(), out widthRectangle);

            Console.WriteLine("Enter the lenght of the rectangle.");
            double.TryParse(Console.ReadLine(), out lenghtRectangle);

            double diagonalRectangle = Math.Sqrt(Math.Pow(widthRectangle, 2) + Math.Pow(lenghtRectangle, 2));
            Console.WriteLine($"Diagonal rectangle = {Math.Round(diagonalRectangle, 2)} \n");
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //Task 4. 
            Console.WriteLine("Task 4");

            int firstNumber = 10;
            string theBestSchool = "Szkoła Dotneta";
            double secondNumber = 12.5;

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //Task 5. 
            //variables
            double weight;
            int phoneNumber;

            Console.WriteLine("Please, give me your name:");
            name = Console.ReadLine();

            Console.WriteLine($"Thank you {name}. Now, give your surname");
            surname = Console.ReadLine();

            Console.WriteLine($"Great {name} {surname} \n");

            Console.WriteLine($"{name}, give me your age");
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine($"{name}, give me your weight");
            double.TryParse(Console.ReadLine(), out weight);

            Console.WriteLine($"{name}, give me your phone number");
            int.TryParse(Console.ReadLine(), out phoneNumber);

            Console.Clear();
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Phone number: {phoneNumber}");

        }
        // enum for exercice one
        enum Gender
        {
            m, //man
            k //woman
        }
    }
}
