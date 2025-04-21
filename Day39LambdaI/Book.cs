public class Book
{
    const double NYS_TAX_RATE = .08;

    private string? title;

    public string? Title { 
        get {
            return title;
        }

        set {
            title = string.IsNullOrEmpty(value) ? "No Title" : value;
        }
    }

    private double price;
    public double Price {
        get {
            return price;
        }

        set {
            price = price < 0 ? 0 : value;
        }
    }

    public double Discount { get; private set; }

    // Instead of modifying the properties, we define the behavior directly
    // in the property subtotal - which takes care of calculating
    // the price minus the discount cost
    // Below is a Lambda Expression for Subtotal
    public double Subtotal => Price - Discount;

    // Instead of modifying the properties, we define the bavior directly
    // in the property tax - which takes care of calculating
    // the total tax price
    // Below is a Lambda Expression for Tax
    public double Tax => Subtotal * NYS_TAX_RATE;
    
    // Instead of modifying the properties, we define the bavior directly
    // in the property total price - which takes care of calculating
    // the total price

    // Subtotal already has the discount price
    // Tax has the tax in respect to the Subtotal
    // Below is a Lambda Expression for TotalPrice
    public double TotalPrice => Subtotal + Tax;

    public Book(string title, double price)
    {
        Title = title;
        Price = price;
    }

    public override string ToString() => $"Title: {Title}\nPrice: {Price:C}";
}