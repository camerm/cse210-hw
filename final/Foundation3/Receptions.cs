using System;

public class Receptions : Events
{
    private string _RSVPemail;



    public Receptions(string tittle, string description, string date, string time, string address, string type, string RSVPemail) : base(tittle, description, date, time, type, address)
    {
        _RSVPemail = RSVPemail;

    }

    public override string FullDetails()
    {
        return $"{base.StandartDetails()}\nConfirm your asistant at: {_RSVPemail}";
    }

}