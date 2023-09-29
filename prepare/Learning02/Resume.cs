using System;
// Importing the System.Collections.Generic namespace for using List<T>
using System.Collections.Generic;


public class Resume
{
    private string _name;          // Private variable to store the person's name
    private List<Job> _jobs = new List<Job>();  // Private list to store job history

    // Constructor to initialize the person's name
    public Resume(string name)
    {
        _name = name;
    }

    // Method to add a job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Method to display the resume including name and job details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop through each job and display its details
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
