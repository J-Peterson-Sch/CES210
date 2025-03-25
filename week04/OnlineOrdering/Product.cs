public class Product {

    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, int productID, double price, int _quantity)
    {
        this._name = productName;
        this._productID = productID;
        this._price = price;
        this._quantity = _quantity;
    }

    public string productInfo()
    {
        return $"{_productID}: {_name}";
    }

    public double cost()
    {
        return _price * _quantity;
    }
}