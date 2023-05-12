using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 15, 20, 25, 30, 35, 40, 45, 50 };
        // Find all even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
        // Find all numbers greater than 20
        int threshold = 20;
        var greaterThanThreshold = numbers.Where(n => n > threshold);
        Console.WriteLine("\nNumbers greater than 20:");
        foreach (var number in greaterThanThreshold)
        {
            Console.WriteLine(number);
        }
        // Calculate the sum of all numbers
        int sum = numbers.Sum();
        Console.WriteLine($"\nSum of all numbers: {sum}");
        // Calculate the average of all numbers
        double average = numbers.Average();
        Console.WriteLine($"Average of all numbers: {average}");
        // Find the minimum and maximum values
        int min = numbers.Min();
        int max = numbers.Max();
        Console.WriteLine($"\nMinimum value: {min}");
        Console.WriteLine($"Maximum value: {max}");
    }
}