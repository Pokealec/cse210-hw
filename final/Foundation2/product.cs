// Contains the name, product id, price, and quantity of each product.
// The price of this product is computed by multiplying the price and the quantity.
public class Product
{
    private string name1;
    private string productID1;
    private double price1;
    private int quantity1;

    public Product(string name, string productID, double price, int quantity)
    {
        name1 = name;
        productID1 = productID;
        price1 = price;
        quantity1 = quantity;
    }

    public int GetPrice(int price, int quantity){
        return price * quantity;
    }

    public string GetName()
    {
        return name1;
    }
    public string GetProductID()
    {
        return productID1;
    }

    public double GetPrice()
    {
        return price1;
    }

    public int GetQuantity()
    {
        return quantity1;
    }


}
