using System.Reflection.Metadata.Ecma335;

class Address
{
    private string _address;
    private string _streetAdress;
    private string _city;
    private string _state;
    private string _country;
    private string _zipCode;
// ----------------------------------------------
    public void SetStreetAddress(string streetAddress)
    {
        _streetAdress = streetAddress;
    }

    public string GetStreetAddress()
    {
        return _streetAdress;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetZipCode(string zipCode)
    {
        _zipCode = zipCode;
    }

    public string GetZipCode()
    {
        return _zipCode;
    }
// ----------------------------------------------
    public void SetAddress(string streetAddress, string city, string state, string country, string zipCode)
    {
        _streetAdress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
        _zipCode = zipCode;
        
        _address = $"{streetAddress} \n{city}, {state} \n{country} \n{zipCode}";
    }

    public string GetAddress()
    {
        return _address;
    }

    public int IsUSA(string country)
    {
        if (country == "USA" || country == "United States of America" || country == "US")
        {
            return 1;
        }

        else
        {
            return 0;
        }
    }
}