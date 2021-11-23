using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
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
            

            
            Console.ReadKey();
        }
    }

}
