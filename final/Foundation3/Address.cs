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

};
