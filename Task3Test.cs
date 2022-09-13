using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task3.Task3;

namespace Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(2000), Is.EqualTo(366));
        That(NumberOfDays(1900), Is.EqualTo(365));
        That(NumberOfDays(2020), Is.EqualTo(366));
        That(NumberOfDays(2025), Is.EqualTo(365));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate1('С', 1, -1), Is.EqualTo('С'));
        That(Rotate1('С', -1, -1), Is.EqualTo('Ю'));
        That(Rotate1('С', 2, -1), Is.EqualTo('З'));
        That(Rotate1('С', 1, 2), Is.EqualTo('В'));
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(20), Is.EqualTo("двадцать лет"));
        That(AgeDescription(55), Is.EqualTo("пятьдесят пять лет"));
        That(AgeDescription(31), Is.EqualTo("тридцать один год"));
        That(AgeDescription(68), Is.EqualTo("шестьдесят восемь лет"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}