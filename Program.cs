using System;

namespace Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new();

        Console.WriteLine("Calculator.");
        Console.WriteLine("Choose Option:");
        Console.WriteLine("1: Add");
        Console.WriteLine("2: Subtract");
        Console.WriteLine("3: Divide");
        Console.WriteLine("4: Multiply");

        string? pressedKey = Console.ReadLine();

        if (pressedKey != "1" && pressedKey != "2" &&
            pressedKey != "3" && pressedKey != "4")
        {
            throw new Exception($"Invalid key: {pressedKey}");
        }

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (pressedKey)
        {
            case "1":
                result = calc.plus(num1, num2);
                break;

            case "2":
                result = calc.minus(num1, num2);
                break;

            case "3":
                result = calc.division(num1, num2);
                break;

            case "4":
                result = calc.multiplication(num1, num2);
                break;
        }

        Console.WriteLine($"Result: {result}");
    }
}