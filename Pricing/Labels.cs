namespace Pricing;

public static class Labels
{
    public static string PriceLabel(decimal price)
    {
        return $"Listed price: {price:C2}";
    }
}
