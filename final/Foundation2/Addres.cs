using System;
public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }
    
    public override string ToString()
    {
        return $"{_street}, {_city}, {_province}. {_country}"; 
    }
    public bool USAaddress()
    {
        if(_country == "USA")
        {
            return true;
        }
        return false;
    }




}