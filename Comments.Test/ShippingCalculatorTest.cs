using LegacyCode;

namespace Comments.Test;

[TestFixture]
[TestOf(typeof(ShippingCalculator))]
public class ShippingCalculatorTest
{

    [Test]
    public void METHOD()
    {
        var cost = ShippingCalculator.Cost(new Order() { ShippingType = "STANDARD", WeightKg = 2 });
        
        Assert.That(1, Is.EqualTo(cost));
    }
}