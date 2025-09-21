using System;
using System.Collections.Generic;
using System.IO;


List<string> questions = new List<string>
{
"Who was the most interesting person I interacted with today?",
"What was the best part of my day?",
"How did I see the hand of the Lord in my life today?",
"What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be ?"
};
List<string> entries = new List<string>();
while (Option != "5")
{
    Console.WriteLine("1: Write");
    Console.WriteLine("2: Display");
    Console.WriteLine("3: Load");
    Console.WriteLine("4: Save");
    Console.WriteLine("5: Exit");
    Console.WriteLine("What would you like to do? ");
    Option = Console.ReadLine();

    if (Option == "1")
    {
        Random rnd = new Random();
        int index = rnd.Next(questions.Count);
        string question = questions[index];
        Console.WriteLine(question);
        Console.WriteLine("Write");
        string text = Console.ReadLine();
        string entry = DateTime.Now.ToString("yyyy-MM-dd HH:mm") + " - " + text;

        entries.Add(entry);
    }

    if (Option == "2")
    {
        if (entries.Count > 0)
        {
            foreach (string e in entries)
            {
                Console.WriteLine(e);
            }
        }
        else
        {
            Console.WriteLine("No entries to display.");
        }
    }

    if (Option == "3")
    {
        Console.WriteLine("What file do you want to load?");
        string FileName = Console.ReadLine();
        if (File.Exists(FileName))
        {
            string[] FileEntries = File.ReadAllLines(FileName);
            Console.WriteLine($"The file {FileName} has been loaded ");
            foreach (string e in FileEntries)
            {
                Console.WriteLine(e);
            }
        }
        else
        {
            Console.WriteLine($"The file {FileName} hasn't been loaded");
        }
    }

    if (Option == "4")
    {
        Console.WriteLine("How would you like to save this file? ");
        String FileName = Console.ReadLine();
        File.AppendAllLines(FileName, entries);
        Console.WriteLine($"The File {FileName} has been saved.");
    }
}

