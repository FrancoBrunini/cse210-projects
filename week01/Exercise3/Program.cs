using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int Guessinput = 0;
        while (Guessinput != number)
        {
            Console.WriteLine("Try to guess the number!: ");
            String Guess = Console.ReadLine();
            Guessinput = int.Parse(Guess);
            if (number > Guessinput)
            {
                Console.WriteLine("Try higher");
            }
            else if (number < Guessinput)
            {
                Console.WriteLine("Try lower");
            }
            else
            {
                Console.WriteLine("Congratulations");
            }
    }
}
        }