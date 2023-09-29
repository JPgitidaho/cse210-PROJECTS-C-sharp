using System;

public class Job
{
    private string _jobTitle;  // Private variable to store the job title
    private string _company;   // Private variable to store the company name
    private int _startYear;    // Private variable to store the start year
    private int _endYear;      // Private variable to store the end year

    // Constructor to initialize the job details
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Method to display job details in a specific format
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
