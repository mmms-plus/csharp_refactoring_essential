using LegacyCode;

namespace Comments.Test;

[TestFixture]
[TestOf(typeof(ShippingCalculator))]
public class ShippingCalculatorTest
{

    [Test]
    public void Standard()
    {
        var cost1 = Calc(StandardOrder(2));
        var cost = cost1;

        Assert.That(1, Is.EqualTo(cost));
    }

    [Test]
    public void Express()
    {
        var cost = Calc(ExpressOrder(10, 10));

        Assert.That(9.0, Is.EqualTo(cost));
    }

    private static double Calc(Order standardOrder)
    {
        return ShippingCalculator.Cost(standardOrder);
    }

    private static Order ExpressOrder(double weightKg, double distanceKm)
    {
        return new Order() { ShippingType = "EXPRESS", WeightKg = weightKg, DistanceKm = distanceKm};
    }

    private static Order StandardOrder(double weightKg)
    {
        return new Order() { ShippingType = "STANDARD", WeightKg = weightKg };
    }
}