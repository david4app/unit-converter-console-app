using System;

namespace UnitConverterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit Converter\n");

            while (true)
            {
                try
                {
                    Console.WriteLine("Select a conversion type:");
                    Console.WriteLine("1. Length");
                    Console.WriteLine("2. Weight");
                    Console.WriteLine("3. Volume");
                    Console.WriteLine("4. Temperature");

                    Console.Write("Enter your choice (1-4): ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ConvertLength();
                            break;
                        case 2:
                            ConvertWeight();
                            break;
                        case 3:
                            ConvertVolume();
                            break;
                        case 4:
                            ConvertTemperature();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid conversion type.");
                            break;
                    }

                    Console.Write("\nDo you want to perform another conversion? (yes/no): ");
                    string continueConv = Console.ReadLine().ToLower();
                    if (continueConv != "yes")
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter numeric values.\n");
                }
            }

            Console.WriteLine("Thank you for using the unit converter. Goodbye!");
        }

        static void ConvertLength()
        {
            Console.WriteLine("\nLength Conversion");
            Console.WriteLine("1. Meters to Feet");
            Console.WriteLine("2. Feet to Meters");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value to convert: ");
            double value = Convert.ToDouble(Console.ReadLine());

            double result;
            if (choice == 1)
            {
                result = value * 3.28084;
                Console.WriteLine($"Result: {result} feet");
            }
            else if (choice == 2)
            {
                result = value / 3.28084;
                Console.WriteLine($"Result: {result} meters");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void ConvertWeight()
        {
            Console.WriteLine("\nWeight Conversion");
            Console.WriteLine("1. Kilograms to Pounds");
            Console.WriteLine("2. Pounds to Kilograms");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value to convert: ");
            double value = Convert.ToDouble(Console.ReadLine());

            double result;
            if (choice == 1)
            {
                result = value * 2.20462;
                Console.WriteLine($"Result: {result} pounds");
            }
            else if (choice == 2)
            {
                result = value / 2.20462;
                Console.WriteLine($"Result: {result} kilograms");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void ConvertVolume()
        {
            Console.WriteLine("\nVolume Conversion");
            Console.WriteLine("1. Liters to Gallons");
            Console.WriteLine("2. Gallons to Liters");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value to convert: ");
            double value = Convert.ToDouble(Console.ReadLine());

            double result;
            if (choice == 1)
            {
                result = value * 0.264172;
                Console.WriteLine($"Result: {result} gallons");
            }
            else if (choice == 2)
            {
                result = value / 0.264172;
                Console.WriteLine($"Result: {result} liters");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void ConvertTemperature()
        {
            Console.WriteLine("\nTemperature Conversion");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value to convert: ");
            double value = Convert.ToDouble(Console.ReadLine());

            double result;
            if (choice == 1)
            {
                result = (value * 9 / 5) + 32;
                Console.WriteLine($"Result: {result} Fahrenheit");
            }
            else if (choice == 2)
            {
                result = (value - 32) * 5 / 9;
                Console.WriteLine($"Result: {result} Celsius");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
