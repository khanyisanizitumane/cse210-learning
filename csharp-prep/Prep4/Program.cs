using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // Prompt the user for numbers and append them to the list
        Console.WriteLine("Enter a series of numbers (enter 0 to stop):");
        int input;
        do
        {
            input = Convert.ToInt32(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        // Calculate the sum of the numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Calculate the average of the numbers in the list
        double average = (double)sum / numbers.Count;

        // Find the maximum number in the list
        int max = numbers.Count > 0 ? numbers[0] : 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // Output results
        Console.WriteLine($"Sum of the numbers: {sum}");
        Console.WriteLine($"Average of the numbers: {average}");
        Console.WriteLine($"Maximum number in the list: {max}");
    }
}
