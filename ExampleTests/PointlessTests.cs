using NUnit.Framework;

namespace ExampleTests;

public class PointlessTests
{
    [Test]
    public void example_failing_test()
    {
        Assert.That(1,Is.EqualTo(2)) ;
    }
    
    [Test]
    public void example_passing_test()
    {
        Assert.That(1,Is.EqualTo(1)) ;
    }
}