

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }


    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetProduct()
    {
        return _name;
    }

    public string GetID()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    //Product p = new Product("Apple", "782944", 12.86, 5);



}