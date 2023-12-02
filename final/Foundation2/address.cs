// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
public class Address
{
    private string street1;
    private string city1;
    private string state1;
    private string country1;

    public Address(string street, string city, string state, string country)
    {
        street1 = street;
        city1 = city;
        state1 = state;
        country1 = country;
    }

    public bool IsUSA()
    {
        return country1 == "USA" ? true : false;
    }

    public string GetAddress()
    {
        string address = street1 + ", " + city1 + "\n" + state1 + ", " + country1;
        return address;
    }

};
