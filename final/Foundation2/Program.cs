using System;
using System.Formats.Asn1;

class Program
{ // Make sure that all member variables are private and getters, setters, and constructors are created as needed.
// Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.
    static void Main(string[] args)
    {
        Address Ad1 = new Address("123 Maple Street", "Mapleton", "The Twilight Zone","USA");
        Customer person1 = new Customer("Pete Van Horn", Ad1);
        string personName1 = person1.GetName();
        string fullAddress1 = Ad1.ConciseAddress();
        // Console.WriteLine($"{personName1}\n{fullAddress1}");
        Product a1 = new Product("Hammer", "Ham290", 4.99, 1);
        Product a2 = new Product("Overalls", "Jon480", 19.99, 2);
        Product a3 = new Product("Science Fiction Archives, Vol II", "SCP000", 12.99, 1);

        List<Product> CartA = new List<Product>(); //creating a new empty list called CartA
        CartA.Add(a1);
        CartA.Add(a2);
        CartA.Add(a3);
        Order OrderA = new Order(CartA, person1);

        Console.WriteLine("Order A");
        OrderA.DisplayResults();

        Console.WriteLine("-_-_-_-_-_-_-_-_-_-_");

        Address Ad2 = new Address("76 Totter's Lane", "Shoreditch", "London", "UK");
        Customer person2 = new Customer("Susan Foreman", Ad2);
        string personName2 = person2.GetName();
        string fullAddress2 = Ad2.ConciseAddress();
        // Console.WriteLine($"{personName1}\n{fullAddress1}");
        Product b1 = new Product("Diary", "Dia541", 3.99, 1);
        Product b2 = new Product("Bob Dylan Records", "BDR217", 3.98, 2);

        List<Product> CartB = new List<Product>(); //creating a new empty list called CartB
        CartB.Add(b1);
        CartB.Add(b2);
        Order OrderB = new Order(CartB, person2);

        Console.WriteLine("Order B");
        OrderB.DisplayResults();

        Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_\n");
    }
}