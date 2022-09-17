using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task5.Task5;

namespace Task5;

public class Tests
{
    private readonly TextReader _standartIn = Console.In;
    private readonly TextWriter _standartOut = Console.Out;
    private StringWriter _stringWriter = new StringWriter();

    [SetUp]
    public void Setup()
    {
        var stringWriter = new StringWriter();
        _stringWriter = stringWriter;
        Console.SetOut(_stringWriter);
    }

    [TearDown]
    public void TearDown()
    {
        Console.SetIn(_standartIn);
        Console.SetOut(_standartOut);
        _stringWriter.Close();
    }

    [Test]
    public void Test1()
    {
        That(Fibb(1), Is.EqualTo(1));
    }

    [Test]
    public void Test2()
    {
        That(Fibb(10), Is.EqualTo(55));
    }

    [Test]
    public void Test3()
    {
        That(Fibb(20), Is.EqualTo(6765));
    }

    [Test]
    public void Test4()
    {
        That(Fibb(25), Is.EqualTo(75025));
    }

    private void AssertOut(String expected)
    {
        That(_stringWriter.ToString().TrimEnd(Environment.NewLine.ToCharArray()), Is.EqualTo(expected));
    }
}