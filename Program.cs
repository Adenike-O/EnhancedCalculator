using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                string choice = Console.ReadLine();

                if (choice == "5") break;

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Result: {num1} + {num2}");
                        break;
                    case "2":
                        Console.WriteLine($"Result: {num1 - num2}");
                        break;
                    case "3":
                        Console.WriteLine($"Result: {num1 * num2}");
                        break;
                    case "4":
                        if (num2 != 0)
                            Console.WriteLine($"Result: {num1 / num2}");
                        else
                            Console.WriteLine("Cannot divide by zero!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;

                    case "6": // Scientific Operations
                        Console.WriteLine("Select a scientific operation:");
                        Console.WriteLine("1. Square Root");
                        Console.WriteLine("2. Exponentiation");
                        Console.WriteLine("3. Logarithm");
                        Console.WriteLine("4. Sine");
                        string sciChoice = Console.ReadLine();

                        Console.Write("Enter a number: ");
                        double sciNum = Convert.ToDouble(Console.ReadLine());

                        switch (sciChoice)
                        {
                            case "1":
                                Console.WriteLine($"Squareroot: {Math.Sqrt(sciNum)}");
                                break;
                            case "2":
                                Console.Write("Enter exponent: ");
                                double exponent = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Result: {Math.Pow(sciNum, exponent)}");
                                break;
                            case "3":
                                Console.WriteLine($"Logarithm: {Math.Log(sciNum)}");
                                break;
                            case "4":
                                Console.WriteLine($"Sine: {Math.Sin(sciNum)}");
                                break;
                            default:
                                Console.WriteLine("Invalid choice!");
                                break;
                        }
                        break;

                    case "7": // Unit Conversions
                        Console.WriteLine("Select a conversion:");
                        Console.WriteLine("1. Meters to Feet");
                        Console.WriteLine("2. Kilograms to Pounds");
                        Console.WriteLine("3. Celsius to Fahrenheit");
                        string convChoice = Console.ReadLine();

                        Console.Write("Enter value: ");
                        double value = Convert.ToDouble(Console.ReadLine());

                        switch (convChoice)
                        {
                            case "1":
                                Console.WriteLine($"{value} meters = {value * 3.28084} feet");
                                break;
                            case "2":
                                Console.WriteLine($"{value} kilograms = {value * 2.20462} pounds");
                                break;
                            case "3":
                                Console.WriteLine($"{value}°C = {(value * 9 / 5) + 32}°F");
                                break;
                            default:
                                Console.WriteLine("Invalid choice!");
                                break;
                        }
                        break;
                }

        }
    }
}
