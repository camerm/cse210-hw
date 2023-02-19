using System;

class Running : Activity
{
    private double _distance;

    public Running(string date, string activiy, double duration, double distance) : base(date, activiy, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

}