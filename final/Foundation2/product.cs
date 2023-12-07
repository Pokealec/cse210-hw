// Contains the name, product id, price, and quantity of each product.
// The price of this product is computed by multiplying the price and the quantity.
public class Product
{
    private string name_ref;
    private string productID_ref;
    private double price_ref;
    private int quantity_ref;

    public Product(string productName, string productID, double price, int quantity)
    {
        name_ref = productName;
        productID_ref = productID;
        price_ref = price;
        quantity_ref = quantity;
    }

    public string ProductName => name_ref;
    public string ProductID => productID_ref;

    public string listProduct(){
        return $"{name_ref} (ID: {productID_ref}) at {price_ref} per item. Quantity: {quantity_ref}";
    }
    public string GetItemQuantity(){
        return $"{name_ref} - x{quantity_ref}";
    }
    public double GetItemTotal(){
        return price_ref * quantity_ref;
    }

}
