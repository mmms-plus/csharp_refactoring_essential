namespace FeatureEnvy;

public class Product
{
    private readonly double price;
    private readonly bool onSale;

    public Product(double price, bool onSale)
    {
        this.price = price;
        this.onSale = onSale;
    }

    public double GetPrice()
    {
        return price;
    }

    public bool IsOnSale()
    {
        return onSale;
    }
}