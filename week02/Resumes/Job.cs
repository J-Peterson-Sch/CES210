using System.Security.Cryptography.X509Certificates;

public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 1900;
    public int _endYear = 1900;
    
    public Job()
    {        
    }

    public void Display()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Company: {_company}");
        Console.WriteLine($"Title: {_jobTitle}");
        Console.WriteLine($"Employment Dates: {_startYear} - {_endYear}");
    }
}