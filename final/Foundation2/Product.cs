using System;
public class Product
{
    private string _nameProduct;
    private string _productId;
    private int _priceProduct;
    private int _quantifyProduct;

    public Product(string nameProduct, string productId, int priceProduct, int quantifyProduct)
    {
        _nameProduct = nameProduct;
        _productId = productId;
        _priceProduct = priceProduct;
        _quantifyProduct = quantifyProduct;
    }
    public string GetNameProduct()
    {
        return _nameProduct;
    }

    public int GetPriceOfProduct()
    {
        return _priceProduct*_quantifyProduct;
    }
    public string GetIDProduct()
    {
        return _productId;
    }
}