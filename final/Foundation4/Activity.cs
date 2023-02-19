using System;

class Activity
{
    private string _date;
    private string _activity;
    private double _duration;


    public Activity(string date, string activiy, double duration)
    {
        _date = date;
        _activity = activiy;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return GetSpeed() * _duration/60.0;;
    }
    public virtual double GetSpeed()
    {
        return GetDistance() /(_duration/60.0);
    }
    public void Summary()
    {
        Console.WriteLine($"{_date} {_activity} ({_duration} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph");
    }

}