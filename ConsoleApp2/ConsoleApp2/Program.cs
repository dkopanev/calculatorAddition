using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop = "0";
            while (stop != "X")
            {
                // Ask for operator
                Console.WriteLine("Please write a valid signal.\n1 = Addition\n2 = Subtraction\n3 = Multiplication\n4 = Division");
                string operatorInput = Console.ReadLine();
                int operation = Convert.ToInt32(operatorInput);

                // Ask for the first number and save it
                Console.WriteLine("Enter your first number number:");
                string nb1 = Console.ReadLine();
                int n1 = Convert.ToInt32(nb1);
                Console.WriteLine("Your first number is: " + n1);

                // Ask for the second number and save it
                Console.WriteLine("Please enter your second number:");
                string nb2 = Console.ReadLine();
                int n2 = Convert.ToInt32(nb2);
                Console.WriteLine("Your second number is: " + n2);

                // solve the math
                if (operation == 1)
                {
                    int ausgabezahl = Addition(n1, n2);
                    Console.WriteLine("Your result is: " + ausgabezahl + "\n");
                }
                else if (operation == 2)
                {
                    int ausgabezahl = Subtraction(n1, n2);
                    Console.WriteLine("Your result is: " + ausgabezahl + "\n");
                }
                else if (operation == 3)
                {
                    int ausgabezahl = Multiplication(n1, n2);
                    Console.WriteLine("Your result is: " + ausgabezahl + "\n");
                }
                else if (operation == 4)
                {
                    int ausgabezahl = Division(n1, n2);
                    Console.WriteLine("Your result is: " + ausgabezahl + "\n");
                }


                // Ask if they want to continue or exit
                Console.WriteLine("If you want to continue write 'I am studid.' and press enter.");
                Console.WriteLine("If you want to exit write 'exit' and press enter.");
                string exit = Console.ReadLine();
                
                //Exit if necessary
                if (exit == "exit")
                {
                    Console.WriteLine("End of loop.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    continue;
                    Console.WriteLine("\n");
                }

            }
        }

        static int Addition(int number1, int number2)
        {
            int ergebnis = number1 + number2;
            Console.WriteLine("Your equation will be: " + number1 + " + " + number2);
            return ergebnis;
        }

        static int Subtraction(int number1, int number2)
        {
            int ergebnis = number1 - number2;
            Console.WriteLine("Your equation will be: " + number1 + " - " + number2);
            return ergebnis;

        }
        static int Multiplication(int number1, int number2)
        {
            int ergebnis = number1 * number2;
            Console.WriteLine("Your equation will be: " + number1 + " * " + number2);
            return ergebnis;
        }
        static int Division(int number1, int number2)
        {
            int ergebnis = number1 / number2;
            Console.WriteLine("Your equation will be: " + number1 + " / " + number2);
            return ergebnis;
        }
    }
}