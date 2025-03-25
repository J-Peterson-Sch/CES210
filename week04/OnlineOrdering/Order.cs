public class Order {

    private Customer _customer;
    private List<Product> _orderedProducts = new List<Product>();
    private double _usShippingCost = 5;
    private double _internationalShippingCost = 35;

    public Order(Customer customer)
    {
        this._customer = customer;
    }

    public void addProduct(Product product)
    {
        _orderedProducts.Add(product);
    }

    public double orderTotal()
    {
        double total = 0;
        foreach (Product product in _orderedProducts)
        {
            total += product.cost();
        }

        if (_customer.livesInUS())
        {
            total += _usShippingCost;
        }
        else
        {
            total += _internationalShippingCost;
        }

        return total;
    }

    public string printPackingLabel()
    {
        string label = "";
        foreach (Product product in _orderedProducts)
        {
             label += $"{product.productInfo()}\n";
        }
        return label;
    }

    public string printShippingLabel()
    {   
        return _customer.customerInfo();
    }
}