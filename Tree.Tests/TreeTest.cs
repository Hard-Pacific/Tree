namespace Tree.Tests;

public class TreeTest
{
    [Test]
    public void CalculateTest()
    {
        var tree = new Tree("(+ 1 (* 9 2))");
        Assert.AreEqual(19, tree.Calculate());

        tree = new Tree("(+ (* 1 2) (- 3 4)");
        Assert.AreEqual(1, tree.Calculate());

        tree = new Tree("(- 0 (/ 1 3)");
        Assert.Less(Math.Abs(tree.Calculate() + .3333), .001);
    }

    [Test]
    public void DivizionByZeroTest()
    {
        var tree = new Tree("(/ 1 0)");
        Assert.Throws<DivideByZeroException>(() => tree.Calculate());

        tree = new Tree("(/ 1 (/ 1 (* 9 (* 9 (* 9 (* 9 (* 9 (* 9 9))))))))");
        Assert.Throws<DivideByZeroException>(() => tree.Calculate());
    }

    [Test]
    public void InvalidOperatorTest()
    {
        Assert.Throws<ArgumentException>(() => new Tree("(l 1 0)"));
    }
}