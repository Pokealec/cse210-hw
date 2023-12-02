// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a // method on the address to find this.)
public class Customer
{
    private string name1;
    private Address address1;


    public Customer(string name, Address address){
        name1 = name;
        address1 = address;
    }

    public bool IsItUSA(){
        return address1.IsUSA() ? true : false;
    }

    public string GetName(){
        return name1;
    }

    public string GetAddress(){
        string theAddress = address1.GetAddress();
        return theAddress;
    }

}


