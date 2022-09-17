using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(2, 2, 2), Is.EqualTo(2));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(2, -200,1), Is.EqualTo(-200));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(2, 0, 3), Is.EqualTo(3));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(2, 2, 2), Is.EqualTo(2));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(2, 2, 1), Is.EqualTo(2));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }

    [Test]
    public void MoreRadDegTests()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
        That(Deg2Rad(90.0), Is.EqualTo(Math.PI * 0.5).Within(1e-5));
        That(Deg2Rad(3 * 360 + 180.0), Is.EqualTo(7 * Math.PI).Within(1e-5));
        That(Deg2Rad(180.0*9), Is.EqualTo(Math.PI*9).Within(1e-5));

        That(Rad2Deg(Math.PI * 0.5), Is.EqualTo(90.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(7 * Math.PI), Is.EqualTo(7 * 180.0).Within(1e-5));
        That(Rad2Deg(Math.PI*9), Is.EqualTo(180.0*9).Within(1e-5));
    }
}