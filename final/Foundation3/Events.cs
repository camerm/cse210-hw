using System;

public class Events
{
    //Attributes
    private string _tittle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;
    
    //Constructors
    public Events(string tittle, string description, string date, string time, Address address, string type)
    {
        _tittle = tittle;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }
    
    //Getters and Setters
    public string GetTittle()
    {
        return _tittle;
    }

    //Methods
    public string StandartDetails()
    {
        return $"Details: {_tittle}\nDescription: {_description}\nDate: {_date}\nHour:{_time}\nPlace: {_address.AddressComplete()}.";
    }
    public virtual string FullDetails()
    {
        return $" Details: {_tittle}, {_description},date: {_date}. Hour: {_time}.Place: {_address.AddressComplete()}. Event Type: {_type}";
    }
    public string ShortDetails()
    {
        return $"Event Type: {_type}\nDetails: {_tittle}\ndate: {_date}.";
    }

}