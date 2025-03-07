using System;

class Program
{
    static void Main(string[] args)
    {
        Job Clearwater = new Job();
        Clearwater._company = "Clearwater";
        Clearwater._jobTitle = "Quality Assurance Analyst";
        Clearwater._startYear = 2017;
        Clearwater._endYear = 2020;

        Job Simplot = new Job();
        Simplot._company = "Simplot";
        Simplot._jobTitle = "Quality Assurance Analyst";
        Simplot._startYear = 2021;
        Simplot._endYear = 2050;

        Resume Jordan = new Resume();
        Jordan._name = "Jordan Peterson";
        Jordan._jobs.Add(Clearwater);
        Jordan._jobs.Add(Simplot);

        Jordan.Display();
    }
}