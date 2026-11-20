using NUnit.Framework;
using Pricing;

namespace Pricing.Tests;

[TestFixture]
public class DiscountsTests
{
    [Test]
    public void ApplyPercent_TenPercentOffTwenty_IsEighteen()
    {
        decimal result = Discounts.ApplyPercent(20m, 10m);
        Assert.That(result, Is.EqualTo(18m));
    }

    [Test]
    public void ApplyPercent_ZeroPercent_LeavesPriceUnchanged()
    {
        decimal result = Discounts.ApplyPercent(20m, 0m);
        Assert.That(result, Is.EqualTo(20m));
    }
}
