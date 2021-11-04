using System;
using CalculatorTraining;
using XUnitTest;

var calculator = new Calculator();
var crazyCalculator = new CrazyCalculator();   
while (true)
{
    int option;
    printMenu();
    if (!int.TryParse(Console.ReadLine(), out option))
        Console.WriteLine("Not valid option\n");
    else
    {
        float x, y;
        switch (option)
        {
            case 1:
                Console.Write("x: ");
                if (!float.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }
                Console.Write("y: ");
                if (!float.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }

                Console.WriteLine("Result: " + calculator.Add(x, y) + "\n");
                break;

            case 2:
                Console.Write("x: ");
                if (!float.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }
                Console.Write("y: ");
                if (!float.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }

                Console.WriteLine("Result: " + calculator.Subtract(x, y) + "\n");
                break;

            case 3:
                Console.Write("x: ");
                if (!float.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }
                Console.Write("y: ");
                if (!float.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }

                Console.WriteLine("Result: " + calculator.Multiply(x, y) + "\n");
                break;

            case 4:
                Console.Write("x: ");
                if (!float.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }
                Console.Write("y: ");
                if (!float.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }

                Console.WriteLine("Result: " + calculator.Divide(x, y) + "\n");
                break;
            case 5:
                Console.Write("x: ");
                if (!float.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }
                Console.Write("y: ");
                if (!float.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }

                var finance = new Finance(calculator);
                Console.WriteLine("Result: " + finance.CustomAction(x, y) + "\n");
                break;
            case 6:
                Console.Write("x: ");
                if (!float.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }
                Console.Write("y: ");
                if (!float.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Not a valid float\n");
                    break;
                }

                var finance2 = new Finance(crazyCalculator);
                Console.WriteLine("Result: " + finance2.CustomAction(x, y) + "\n");
                break;

            case 7:
                return;

            default:
                Console.WriteLine("Not valid option\n");
                break;
        }
    }
}



void printMenu()
{
    Console.WriteLine("=========================== Calculator ===========================");
    Console.WriteLine("1. Add (x+y)......................................................");
    Console.WriteLine("2. Subtract (x-y).................................................");
    Console.WriteLine("3. Multiply (x*y).................................................");
    Console.WriteLine("4. Divide (x/y)...................................................");
    Console.WriteLine("5. CustomAction Normal Calculator [(x^2)+(y^2)+10]................");
    Console.WriteLine("6. CustomAction Crazy Calculator [(x^2)+(y^2)+12].................");
    Console.WriteLine("7. Exit...........................................................");
    Console.Write("Input: ");
}