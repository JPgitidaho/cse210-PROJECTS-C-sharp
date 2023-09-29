using System;
using System.Collections.Generic; // Importing the System.Collections.Generic namespace

// Define the Resume class
public class Resume
{
    public string _name;  // Stores the person's name

    // Create a list to store Job instances
    public List<Job> _jobs = new List<Job>();

    // Method to display resume details
    public void Display()
    {
        // Display the person's name
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through each Job instance and display job details
        foreach (Job job in _jobs)
        {
            job.Display(); // Calls the Display method of the Job class
        }
    }
}
