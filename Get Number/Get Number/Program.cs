﻿using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

       
        double sum = number1 + number2;

        Console.WriteLine("Sum: " + sum);
    }
}
