using System;

class Program
{
    static void Main(string[] args)
    {

        List<Events> events_market = new List<Events>();

        Address address1 = new Address("av rpogreso 104", "Sachaca", "arequipa", "Peru");
        Address address2 = new Address("av progreso", "Yanahuara", "Arequipa", "Peru");
        Address address3 = new Address("san Austin Satdium", "socabayaa", "Arequipa", "Peru");

        Lectures Lecture1 = new Lectures("University Lecture", "Mathematical Social lecture", "15-02-2023", "15:00", address1, "university activity", "Oliverio Cameron", 20);
        Receptions Receptions1 = new Receptions("J&L married", "the married of Julia and leo", "27-02-2023", "08:00", address2, "social Activity", "cameron.ocm@gmail.com");
        OutdoorGatherings OutdoorGatherings1 = new OutdoorGatherings("Romeo Santos concert", "25th anyversary of UNSA with Romeo Santos Concent", "18-02-2023", "09:30", address3, "social Activity", "rainy");

        events_market.Add(Lecture1);
        events_market.Add(Receptions1);
        events_market.Add(OutdoorGatherings1);

        Console.WriteLine("------------Full Details----------");   
        foreach (Events ev in events_market)
        {
            Console.WriteLine();
            Console.WriteLine(ev.FullDetails());
            Console.WriteLine();
        }
        Console.WriteLine("------------Short Details----------");   
        foreach (Events ev in events_market)
        {
            Console.WriteLine();
            Console.WriteLine(ev.ShortDetails());
            Console.WriteLine();
        }
        Console.WriteLine("------------Standart Details----------");   
        foreach (Events ev in events_market)
        {
            Console.WriteLine();
            Console.WriteLine(ev.StandartDetails());
            Console.WriteLine();
        }

    }
}