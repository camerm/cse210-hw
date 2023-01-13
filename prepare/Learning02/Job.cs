public class Job
{
    public string _company;
    public string _jobTitlle;
    public int _startYear;
    public int _endYear;


    public void Display()
    {
        Console.WriteLine($"{_jobTitlle} ({_company}) {_startYear}-{_endYear}");
    }
}