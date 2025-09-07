using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string GradeUser = Console.ReadLine();
        int number = int.Parse(GradeUser);
        if (number >= 90)
        {
            Console.WriteLine("You have a A");
        }
        else if (number >= 80)
        {
            Console.WriteLine("You have a B");
        }
        else if (number >= 70)
        {
            Console.WriteLine("You have a C");
        }
        else if (number < 60)
        {
            Console.WriteLine("You have a F");
        }
    }

    }
