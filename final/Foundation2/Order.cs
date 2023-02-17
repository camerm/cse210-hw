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

    public int TotalCost()
    {
        int total = 0;
        foreach(Product product in _products)
        {
            total +=product.GetPriceOfProduct();
        }
        return total;
    }

    public string PackingLabel()
    {
        string packingLabel = "Packing Label:";
        packingLabel += "\n Name  -  ID";
        foreach (Product product in _products)
        {
            packingLabel += "\n"+ product.GetNameProduct() + "  -  " + product.GetIDProduct();
        }
        return packingLabel;
    }
    
    public string ShippingLabel()
    {
        string shippingLabel = "Shipping Label:";
        shippingLabel += _customer.GetNameCustomer();
        shippingLabel += _customer.GetAddressCustomer();
        return shippingLabel;
    }

    public int deliveryPrice()
    {
        if(_customer.USAcustomer())
        {
            return 5;
        }
        return 35;
    }

    public decimal TotalPrice()
    {
        return (TotalCost() + deliveryPrice());    
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}