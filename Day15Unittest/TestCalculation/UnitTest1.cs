namespace TestCalculation;

public class Tests
{
    [Test]
    public void TestAdd()
    {
        // Setup
        double  a = 3,
                b = 5;

        double expected = 8;

        // Invoke
        Calculate calculate = new();
        double actual = calculate.Add(a, b);

        // Analyze
        Assert.That(actual, Is.EqualTo(expected));
    }
}
