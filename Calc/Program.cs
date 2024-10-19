using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Choose an operation (+, -, *, /): ");
        char op = char.Parse(Console.ReadLine());

        double result;

        if (op == '+')
        {
            result = num1 + num2;
        }
        else if (op == '-')
        {
            result = num1 - num2;
        }
        else if (op == '*')
        {
            result = num1 * num2;
        }
        else if (op == '/')
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return; 
            }
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Invalid operation.");
            return; 
        }

        Console.WriteLine("Result: " + result);
    }
}