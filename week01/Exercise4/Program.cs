using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        Console.WriteLine("Type a number. Type 0 when you have finished");
        int number = -1;
        while (number != 0)
        {
            string newnumber = Console.ReadLine();
            number = int.Parse(newnumber);
            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        int sum = 0;
        double average = 0;
        int higher = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers [i] > higher)
            {
                higher = numbers [i];
            }


        }
        average = sum / numbers.Count;
        Console.WriteLine($"The total sum of the list is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The higher number is: {higher}");
    }
}