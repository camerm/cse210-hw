using System;

public class OutdoorGatherings : Events
{
    private string _weather;



    public OutdoorGatherings(string tittle, string description, string date, string time, string address, string type, string weather) : base(tittle, description, date, time, address, type)
    {
        _weather = weather;

    }

    public override string FullDetails()
    {
        return $"{base.StandartDetails()}\nThe weather for this day will be: {_weather}";
    }
}