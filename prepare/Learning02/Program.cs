using System;
using System.Collections.Generic; // Required for List<T>

public class Job
{
    // Properties
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }
}

public class Resume
{
    // Properties
    public string Name { get; set; }
    public List<Job> Jobs { get; set; }

    // Constructor
    public Resume()
    {
        Jobs = new List<Job>();
    }

    // Method to display resume information
    public void Display()
    {
        Console.WriteLine("Resume of: " + Name);
        Console.WriteLine("Jobs:");

        foreach (var job in Jobs)
        {
            Console.WriteLine($"- {job.JobTitle} at {job.Company} from {job.StartYear} to {job.EndYear}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            JobTitle = "Software Engineer",
            Company = "Microsoft",
            StartYear = 2019,
            EndYear = 2022
        };

        Job job2 = new Job
        {
            JobTitle = "Manager",
            Company = "Apple",
            StartYear = 2022,
            EndYear = 2023
        };

        Resume myResume = new Resume
        {
            Name = "Allison Rose"
        };

        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        myResume.Display();
    }
}
