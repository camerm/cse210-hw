using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures Lecture1 = new Lectures("University Lecture", "Mathematical Social lecture", "15-02-2023", "15:00", "av salaverry 308 Huaranguillo", "university activity", "Oliverio Cameron", 20);
        Console.WriteLine(Lecture1.FullDetails());

        Receptions Receptions1 = new Receptions("J&L married", "the married of Julia and leo", "27-02-2023", "08:00", "av rpogreso 104 Sachaca", "social Activity", "cameron.ocm@gmail.com");
        Console.WriteLine(Receptions1.FullDetails());

        Receptions OutdoorGatherings1 = new Receptions("Romeo Santos concert", "25th anyversary of UNSA with Romeo Santos Concent", "18-02-2023", "09:30", "san Agustin stadium", "social Activity", "rainy");
        Console.WriteLine(OutdoorGatherings1.FullDetails());
    }
}