using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Console.WriteLine("Hello World! This is the Resumes Project.");
        job1._name = "Software Engineer";
        job1._company = "Microsoft";
        job1._startyear = 1970;
        job1._endyear = 2025;
        

        Job job2 = new Job();
        job2._name = "Manager";
        job2._company = "Apple";
        job2._startyear = 2022;
        job2._endyear = 2023;
        

        Resume myResume = new Resume();
        myResume._name = "Franco Bruñini";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.displayy();

    }
}