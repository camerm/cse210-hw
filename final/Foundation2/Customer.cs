using System;
public class Customer
{

    private string _nameCustomer;
    private Address _addressCustomer;

    public Customer(string nameCustomer, Address addressCustomer)
    {
        _nameCustomer = nameCustomer;
        _addressCustomer = addressCustomer;
    }

    public string GetNameCustomer()
    {
        return _nameCustomer;
    }

    public bool USAcustomer()
    {
        return _addressCustomer.USAaddress();
    }
    public string GetAddressCustomer()
    {
        return _addressCustomer.ToString();
    }
}