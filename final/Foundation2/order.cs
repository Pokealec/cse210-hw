// Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
// The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer
public class Order
{
    private List<Product> products1;
    private Customer customer1;

    public Order(List<Product> products, Customer customer){
        products1 = products;
        customer1 = customer;
    }

    public double CalcShipping(){
        double shippingCost = customer1.IsItUSA() ? 5 : 35;
        return shippingCost;
    }

    public double CalcTotalPrice(){
        double totalPrice = 0;
        foreach(Product p in products1){
            double price = p.GetPrice();
            totalPrice += price;
        }
        double shippingCost = CalcShipping();
        totalPrice += shippingCost;
        return totalPrice;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product p in products1) 
        {
            packingLabel += p.GetName() + " - " + p.GetProductID() + "\n";
        }
        return packingLabel;
    }

     public string GenerateShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += customer1.GetName() + "\n" + customer1.GetAddress();
        return shippingLabel;
    }

    public string GenerateTotalCost()
    {
        string totalCost = "\nProducts:\n";
        double totalPrice = CalcTotalPrice();
        foreach (Product p in products1) 
        {
            totalCost += p.GetName() + " (" + p.GetProductID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.GetPrice() + "\n";
        }
        
        totalCost += "Shipping Cost: $" + CalcShipping() + "\n";
        totalCost += "Total: $" + CalcTotalPrice();
        
        return totalCost;
    }

    public void DisplayResults()
    {
        string packingLabel = GeneratePackingLabel();
        string shippingLabel = GenerateShippingLabel();
        string totalCost = GenerateTotalCost();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine(totalCost);
    }




}
