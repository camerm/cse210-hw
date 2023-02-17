using System;
public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order (Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
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