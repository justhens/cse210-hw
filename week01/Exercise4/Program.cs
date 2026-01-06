using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> values = new List<int>();
        Console.WriteLine("Enter a list of numbers one at a time, enter 0 when finished.");
        int input;

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                values.Add(input);
            }

        } while (input != 0);

        int total = 0;
        int largest = values[0];

        foreach (int value in values)
        {
            total += value;

            if (value > largest)
            {
                largest = value;
            }
        }

        double average = (double)total / values.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}
