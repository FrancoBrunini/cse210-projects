using System;

public class Job
{
    public string _name;
    public string _company;
    public int _startyear;
    public int _endyear;
    public void displayy()
    {
        Console.WriteLine($"{_name} ({_company}) {_startyear}-{_endyear}");
    }
}