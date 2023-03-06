using NUnit.Framework;

namespace PrimeService.Tests;

public class Tests
{
    private DemoService _demoService;
    
    [SetUp]
    public void Setup()
    {
        _demoService = new DemoService();
    }

    [Test]
    public void IsMoreThan2_InputIs1_ReturnFalse()
    {
        var result = _demoService.IsMoreThan2(1);

        Assert.IsFalse(result, "1 比 2小");
        //Assert.Pass();
    }

    [TestCase(0)]
    [TestCase(1)]
    public void IsMoreThan2_ValuersMoreThan2_ReturnFalse(int value)
    {
        var result = _demoService.IsMoreThan2(value);

        Assert.IsFalse(result, $"{value} 比 2小");
    }

    [TestCase(3)]
    [TestCase(4)]
    public void IsMoreThan2_ValuersMoreThan2_ReturnTrue(int value)
    {
        var result = _demoService.IsMoreThan2(value);

        //Assert.IsFalse(result, $"{value} 比 2大");
        Assert.IsTrue(result, $"{value} 比 2大");
    }
}