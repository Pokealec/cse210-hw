// Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
// The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer
using System.Text;

public class Order
{
    private List<Product> products_ref;
    private Customer customer_ref;

    public Order(List<Product> products, Customer customer)
    {
        products_ref = products;
        customer_ref = customer;
    }

    public string GetPackingLabel(){
        StringBuilder packingLabel = new StringBuilder();
        foreach (var item in products_ref){  // for item in list...
            packingLabel.AppendLine($"{item.ProductName} - ID: {item.ProductID}");
        }
        string PackingLabel = packingLabel.ToString();
        return PackingLabel;
    }
    public string GetShippingLabel(){
        return $"{customer_ref.CustomerName}\n{customer_ref.CustomerAddress.ConciseAddress()}\nShipping is $5 in USA, $35 outside of USA.";
    }

    public double GetSubtotal()     // got help from ChatGPT
    {
        double total = 0;
        bool isFromUSA = customer_ref.IsFromUSA(); // fromthismethod.usethisvariable 

        foreach (var product in products_ref)
        {
            double itemTotal = product.GetItemTotal(); 
            Console.WriteLine(product.listProduct());
            total += itemTotal;
        }
        if (isFromUSA) // if true
        {
            total += 5.00;
        }
        else
        {
            total += 35.00;
        }
        return total;
    }
public void DisplayResults()
{
    Console.WriteLine("Packing Label:");
    Console.WriteLine(GetPackingLabel());
    Console.WriteLine("Shipping Label:");
    Console.WriteLine(GetShippingLabel());
    Console.WriteLine("\nProducts and Prices:");  // Add a newline for separation
    Console.WriteLine("Includes Shipping Cost (see above)");
    Console.WriteLine($"Subtotal: {GetSubtotal()}");
}

}
