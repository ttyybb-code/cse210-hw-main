public class Address
{
    private string _StreetAddress;
    private string _City;
    private string _State;
    private string _Country;

    public Address(string StreetAddress, string City, string State, string Country)
    {
        _StreetAddress = StreetAddress;
        _City = City;
        _State = State;
        _Country = Country;
    }
    public bool CheckUSA()
    {
        if (_Country == "USA")
        {return true;}
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_StreetAddress}\n{_City}\n{_State}\n{_Country}";
    }

}