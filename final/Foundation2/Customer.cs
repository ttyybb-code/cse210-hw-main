public class Customer
{
    private string _Name;
    private Address _Address;

    public Customer(string name, Address address)
    {
        _Name = name;
        _Address = address;
    }
    public bool CheckUSA()
    {
        return _Address.CheckUSA();
    }
    public string GetName()
    {
        return _Name;
    }
    public string GetAddress()
    {
        return _Address.GetAddress();
    }
}