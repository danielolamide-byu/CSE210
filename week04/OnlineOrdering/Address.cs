

using System.Runtime.CompilerServices;

public class Address
{
    private string _streetAddress, _city, _state, _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }


    public string FullAddress()
    {
        return $"{_streetAddress}, \n{_city}, {_state}, \n{_country}";
    }
    public bool LivesInUSA()
    {
        return _country.Trim().ToUpper() == "USA";
    }
}

    