using System;
using System.Collections.Generic;

public class Resume
{
    private string _name;
    private List<Job> _jobs = new List<Job>();

    public Resume(string name)
    {
        _name = name;
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}