using System;
public class Order
{
    private string _customer;
    private List<Products> _products;

    public Order (string customer)
    {
        _customer = customer;
        _products = new List<Products>();
    }

    public void TotalCost()
    {

    }
    public void PackingLabel()
    {
        
    }
    public void ShippingLabel()
    {
        
    }
}