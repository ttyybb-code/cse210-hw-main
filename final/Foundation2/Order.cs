public class Order
{
    private List<Product> _Products = new List<Product>();
    private Customer _Customer;
    private double _TotalCost;
    private string _ShippingLabel;
    private string _PackingLabel;
    private int _ShippingCost;

    public Order(Customer customer)
    {
        _Customer = customer;
        if (customer.CheckUSA())
        {
            _ShippingCost = 5;
        }
        else
        {
            _ShippingCost = 35;
        }
    }
    public void AddProduct(Product product, int Quantity)
    {  
        product.SetQuantity(Quantity);
        _Products.Add(product);
    }
    public void CalculatePrice()
    {
        foreach (Product product in _Products)
        {
            _TotalCost += product.GetPrice() * product.GetQuantity();
        }
        _TotalCost += _ShippingCost;
        _TotalCost = Math.Round(_TotalCost, 2);
    }
    
    public double GetPrice()
    {
        return _TotalCost;
    }
    public void MakePackingLabel()
    {
        
        foreach(Product product in _Products)
        {
            _PackingLabel = _PackingLabel + product._GetName() + " " + ":" + " " + $"{product.GetProductID()}" + "\n";
        }
    }
    public string GetPackingLabel()
    {

        return _PackingLabel;
    }

    public void MakeShippingLabel()
    {
        _ShippingLabel = _Customer.GetName() + "\n" + _Customer.GetAddress();
    }
    public string GetShippingLabel()
    {
        return _ShippingLabel;
    }
}