using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitlle = "Environmental engineer";
        job1._company = "Walsh Peru";
        job1._startYear = 2015;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitlle = "civil engineer";
        job2._company = "WSP";
        job2._startYear = 2018;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Oliverio Cameron";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.Display();
    }
}