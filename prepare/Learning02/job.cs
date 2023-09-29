using System;

// Define the Job class
public class Job
{
    // Member variables for job details
    public string _jobTitle;  // Stores the job title
    public string _company;   // Stores the company name
    public int _startYear;    // Stores the start year
    public int _endYear;      // Stores the end year

    // Method to display job details
    public void Display()
    {
        // Display job information in the specified format
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
