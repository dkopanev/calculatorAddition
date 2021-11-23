using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("For Adition press '1'\nFor Subtraction press '2'\nFor Multiplication press '3'\nFor Division press '4'");
            string oparatorTyped = Console.ReadLine();
            
            int number = Convert.ToInt32(oparatorTyped);

            if (number == 1)
            {
                Console.WriteLine("Addition");

                // Ask for a first number

                Console.WriteLine("Type in your first number:");
                string firstNumber = Console.ReadLine();
                int number1 = Convert.ToInt32(firstNumber);

                // Write the first number to the Console
                Console.WriteLine("Your first number is: " + number1);

                //Ask for a second number
                Console.WriteLine("Type in your second number: ");
                string secondNumber = Console.ReadLine();
                int number2 = Convert.ToInt32(secondNumber);

                // Write the second number to the Console
                Console.WriteLine("Your second number is: " + number2);

                // Math

                Console.WriteLine("Your equation will be: " + number1 + " + " + number2);

                int result = number1 + number2;

                // Print result

                Console.WriteLine("Your result will be: " + result);

            }

            else if (number == 2)
            {
                Console.WriteLine("Subtraction");

                // Ask for a first number

                Console.WriteLine("Type in your first number:");
                string firstNumber = Console.ReadLine();
                int number1 = Convert.ToInt32(firstNumber);

                // Write the first number to the Console
                Console.WriteLine("Your first number is: " + number1);

                //Ask for a second number
                Console.WriteLine("Type in your second number: ");
                string secondNumber = Console.ReadLine();
                int number2 = Convert.ToInt32(secondNumber);

                // Write the second number to the Console
                Console.WriteLine("Your second number is: " + number2);

                // Math

                Console.WriteLine("Your equation will be: " + number1 + " - " + number2);

                int result = number1 - number2;

                // Print result

                Console.WriteLine("Your result will be: " + result);

            }

            else if (number == 3)
            {
                Console.WriteLine("Multiplication");

                // Ask for a first number

                Console.WriteLine("Type in your first number:");
                string firstNumber = Console.ReadLine();
                int number1 = Convert.ToInt32(firstNumber);

                // Write the first number to the Console
                Console.WriteLine("Your first number is: " + number1);

                //Ask for a second number
                Console.WriteLine("Type in your second number: ");
                string secondNumber = Console.ReadLine();
                int number2 = Convert.ToInt32(secondNumber);

                // Write the second number to the Console
                Console.WriteLine("Your second number is: " + number2);

                // Math

                Console.WriteLine("Your equation will be: " + number1 + " * " + number2);

                int result = number1 * number2;

                // Print result

                Console.WriteLine("Your result will be: " + result);
            }

            else if (number == 4)
            {
                Console.WriteLine("Division");

                // Ask for a first number

                Console.WriteLine("Type in your first number:");
                string firstNumber = Console.ReadLine();
                int number1 = Convert.ToInt32(firstNumber);

                // Write the first number to the Console
                Console.WriteLine("Your first number is: " + number1);

                //Ask for a second number
                Console.WriteLine("Type in your second number: ");
                string secondNumber = Console.ReadLine();
                int number2 = Convert.ToInt32(secondNumber);

                // Write the second number to the Console
                Console.WriteLine("Your second number is: " + number2);

                // Math

                Console.WriteLine("Your equation will be: " + number1 + " / " + number2);

                int result = number1 / number2;

                // Print result

                Console.WriteLine("Your result will be: " + result);
            }

            else
            {
                Console.WriteLine("Please press a number from 1 to 4");
            }

            Console.ReadKey();
        }
            
    }

}
