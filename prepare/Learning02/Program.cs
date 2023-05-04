using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        var job1 = new Job();
        var job2 = new Job();

        job1.jobTitle = "Software Engineer";
        job1.company = "Microsoft";
        job1.startYear = 2019;
        job1.endYear = 2022;

        job2.jobTitle = "Manager";
        job2.company = "Apple";
        job2.startYear = 2022;
        job2.endYear = 2023;

        job1.Display();
        job2.Display();
        
        var myResume = new Resume();
        myResume.name = "Allison Rose";
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);
        myResume.DisplayResume();
    }
}

public class Job {
    public string jobTitle;
    public string company;
    public int startYear;
    public int endYear;

    public void Display() {
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }
}

class Resume {
    public string name;
    public List<Job> Jobs = new List<Job>();
    public void DisplayResume() {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in Jobs) {
            job.Display();
        }
    }
}