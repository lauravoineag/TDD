using NUnit.Framework;
using Examples;

namespace ExampleTests;

public class HeadacheTests
{
    private Headache _sut;  //subject under test 

    [SetUp]
    public void set_up()
    {
        _sut = new Headache(); //instance of class we are testing
    }
    
    [Test]
    public void empty_list_returns_empty_list()
    {
        //arrange
        //var emptyList = new List<int>();
        var emptyList = Enumerable.Empty<int>(); //creating an empty list

        //act 
        var result = _sut.MultiplyList(emptyList, 5); //calling method under test

        //assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void int_in_list_is_multiplied()
    {
        //arrange
        var listOfNumbers = new[] {1, 2, 3};

        //act
        //sut.MultiplyList(new[] {1, 2, 3}, 5);
        var result = _sut.MultiplyList(listOfNumbers, 5);

        //assert
        Assert.That(result, Is.EqualTo(new[] {5, 10, 15}));
    }
}