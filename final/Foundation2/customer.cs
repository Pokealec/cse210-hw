// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a // method on the address to find this.)
using System.Reflection.Emit;

public class Customer
{
    private string name_ref;
    private Address address_ref;
    
    public string CustomerName => name_ref;
    public Address CustomerAddress => address_ref;

    //  type "ctor" = auto build a Constructor 
    public Customer(string name, Address address)
    {
        name_ref = name;
        address_ref = address;
    }

    public string GetName(){
        return name_ref;
    }

    public bool IsFromUSA()
    {
        // if address contains 'usa' in country, then = true
        if (this.address_ref.GetCountry().ToLower() == "usa"){
            return true;
        }
        else{
            return false;
        }
    }
}