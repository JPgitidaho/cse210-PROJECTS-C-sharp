using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the Job class
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create a Resume instance
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // Add the job instances to the Resume's list of jobs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();
    }
}
