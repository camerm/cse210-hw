using System;

public class Lectures : Events
{
    private string _speacker;
    private int _capacityLimit;


    public Lectures(string tittle, string description, string date, string time, string address, string type, string speacker, int capacityLimit) : base(tittle, description, date, time, type, address)
    {
        _speacker = speacker;
        _capacityLimit = capacityLimit;

    }

    public override string FullDetails()
    {
        return $"{base.StandartDetails()} Speacker: {_speacker}, capacity: {_capacityLimit}";
    }

}