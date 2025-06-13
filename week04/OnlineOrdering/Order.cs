


public class Order
{
    private Customer _customer;
    public List<Product> _products = new List<Product>();

    public Order(Customer customer, List<Product> product)
    {
        _customer = customer;
        _products = product;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double Total()
    {
        double total = 0;
        foreach (Product product in _products)
            total += product.GetTotalPrice();

        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string PackagingLabel()
    {
        string label = "";
        foreach (Product product in _products)
            label += $"Product: {product.GetProduct()}, ProductID: {product.GetID()}, Quantity: {product.GetQuantity()}\n";
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()} \n{_customer.GetAddress().FullAddress()}";
    }

}