namespace Pricing;

public static class Discounts
{
    // Takes a percentage off a price. For example, 10 takes 10 percent off.
    public static decimal ApplyPercent(decimal price, decimal percent)
    {
        decimal discount = price * percent / 100;
        return price - discount;
    }
}
