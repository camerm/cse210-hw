using System;
public class Product
{
    private string _nameProduct;
    private string _productId;
    private int _priceProduct;
    private int _quantifyProduct;

    public void SetNameProduct(string nameProduct)
    {
        _nameProduct = nameProduct;
    }
    public string GetNameProduct()
    {
        return _nameProduct;
    }

    public int PriceOfProduct()
    {
        return _priceProduct*_quantifyProduct;
    }
}