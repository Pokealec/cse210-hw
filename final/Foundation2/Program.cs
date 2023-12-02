using System;

class Program
{ // Make sure that all member variables are private and getters, setters, and constructors are created as needed.
// Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("16827 Highland Country Drive", "Cypress", "Texas", "USA");
        Customer customer1 = new Customer("Miles McDonald", address1);
        List<Product> productsList1 = new List<Product>();

        // Product(string name, string productID, double price, int quantity)
        Product prod1 = new Product("Jelly Babies", "DW63", 12.98, 5);
        Product prod2 = new Product("Bannana", "KP19", 2.10, 1);
        Product prod3 = new Product("Notebook", "JT12", 0.89, 4);

        productsList1.Add(prod1);
        productsList1.Add(prod2);
        productsList1.Add(prod3);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("123 Maple Street", "Twilight Zone", "The Twilight Zone", "USA");
        Customer customer2 = new Customer("Pete Van Horn", address2);
        List<Product> productsList2 = new List<Product>();

        Product prod4 = new Product("Hammer", "HLSET", 6.99, 1);
        Product prod5 = new Product("Overalls", "IC100", 21.95, 2);
        Product prod6 = new Product("Science Fiction Archives, Vol II", "SCP1000", 12.99, 1);

        productsList2.Add(prod4);
        productsList2.Add(prod5);
        productsList2.Add(prod6);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("50 E North Temple Street", "Salt Lake City", "Utah 84150", "USA");
        Customer customer3 = new Customer("Elder A. L. McDonald", address3);
        List<Product> productsList3 = new List<Product>();

        Product prod7 = new Product("Bread Cookbook", "EP001", 18.29, 1);
        Product prod8 = new Product("The SPONGE III", "SBSP2", 4.99, 1);
        Product prod9 = new Product("Book of Mormon: Journal Edition", "BOMJE", 25.99, 1);

        productsList3.Add(prod7);
        productsList3.Add(prod8);
        productsList3.Add(prod9);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}