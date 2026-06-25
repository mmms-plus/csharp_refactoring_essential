using LegacyCode;

namespace Comments.Test;

[TestFixture]
[TestOf(typeof(ShippingCalculator))]
public class ShippingCalculatorTest
{

    [Test]
    public void Standard()
    {
        var cost = ShippingCalculator.Cost(new Order() { ShippingType = "STANDARD", WeightKg = 2 });
        
        Assert.That(1, Is.EqualTo(cost));
    }
    
    [Test]
    public void Express()
    {
        var cost = ShippingCalculator.Cost(new Order() { ShippingType = "EXPRESS", WeightKg = 10, DistanceKm = 10});
        
        Assert.That(9.0, Is.EqualTo(cost));
    }
}