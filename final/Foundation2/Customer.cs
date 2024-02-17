class Customer
{
    private string _name;
    private string _address;

    private string _shippingLabel;
// ----------------------------------------------
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }

    public string GetAddress()
    {
        return _address;
    }
// ----------------------------------------------
    public void SetShippingLabel(string name, string address)
    {
        _shippingLabel = $"{name} \n{address}";
    }

    public string GetShippingLabel()
    {
        return _shippingLabel;
    }

    public string IsUSA(int countryCode)
    {
        if (countryCode == 1)
        {
            return "yes";
        }

        else
        {
            return "no";
        }
    }
}