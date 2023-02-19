using System;

public class Events
{
    private string _tittle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    private string _type;

    public Events(string tittle, string description, string date, string time, string address, string type)
    {
        _tittle = tittle;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    
    }

    public string GetTittle()
    {
        return _tittle;
    }

    public string StandartDetails()
    {
        return $"Details: {_tittle}\nDescription: {_description}\nDate: {_date}\nHour:{_time}\nPlace: {_address}.";
    }
    public virtual string FullDetails()
    {
        return $" Details: {_tittle}, {_description},date: {_date}. Hour: {_time}.Place: {_address}. Event Type: {_type}";
    }
    public string ShortDetails()
    {
        return $"Event Type: {_type}\nDetails: {_tittle}\ndate: {_date}.";
    }

}