using LegacyCode;

namespace Comments.Test;

[TestFixture]
[TestOf(typeof(ShippingCalculator))]
public class ShippingCalculatorTest
{

    [Test]
    public void METHOD()
    {
        var cost = ShippingCalculator.Cost(new Order() { ShippingType = "STANDARD"});
        
        Assert.That(0, Is.EqualTo(cost));
    }
}