using System.Dynamic;

public class Product
{
    private string _Name;
    private int _ProductID;
    private double _Price;
    private int _Quantity;

    public Product(string Name, int ID, double Price)
    {
        _Name = Name;
        _ProductID = ID;
        _Price = Price;
    }

    public void SetQuantity(int Quantity)
    {
        _Quantity = Quantity;
    }
    public int GetQuantity()
    {
        return _Quantity;
    }
    public int GetProductID()
    {
        return _ProductID;
    }
    public string _GetName()
    {
        return _Name;
    }
    public double GetPrice()
    {
        return _Price;
    }
}