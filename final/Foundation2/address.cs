// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
public class Address
{
    private string _street; // currently empty variables, will get values when passed from Address() function
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country) // this is where variables come in
    {
        _street = street;   // this is assigning the private variables with the values passed in
        _city = city;
        _state = state;
        _country = country;
    }

    public string ConciseAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

    public string GetCountry()
    {
        return _country;
    }

};
