using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int Square = SquareNumber(number);

        DisplayResult(name, Square);
        

    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            return Console.ReadLine();
            
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favourite number? ");
            return int.Parse(Console.ReadLine());
        
        }
        static int SquareNumber(int InputNumber)
        {
            return InputNumber * InputNumber;

        }

        static void DisplayResult(string PromptUserName, int SquareNumber)
        {
            Console.WriteLine($"{PromptUserName}, the square of your number is {SquareNumber}");
        }

        

}