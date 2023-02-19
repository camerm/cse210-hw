using System;

public class Lectures : Events
{
    private string _speacker;
    private int _capacityLimit;

    public Lectures(string tittle, string description, string date, string time, string address, string type, string speacker, int capacityLimit): base(tittle, description, date, time, type, address)
    {
        _speacker = speacker;
        _capacityLimit = capacityLimit;
    }

    public override string FullDetails()
    {
        return $"Details: {_tittle}, {_description},date: {_date}.Hour: {_time}.Place: {_address}. Event Type: {_type}\nSpeacker: {_speacker}, capacity: {_capacityLimit}";
    }

}