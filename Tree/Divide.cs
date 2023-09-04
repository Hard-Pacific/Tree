namespace Tree;

using System;

/// <summary>
/// Defines a division operator.
/// </summary>
internal class Divide : Operator
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Divide"/> class.
    /// </summary>
    /// <param name="left">Left child tree node.</param>
    /// <param name="right">Right child tree node.</param>
    public Divide(ITreeNode left, ITreeNode right)
        : base(left, right)
    {
        this.op = '/';
    }

    /// <inheritdoc/>
    public override double Calculate()
    {
        double r = this.right.Calculate();
        return Math.Abs(r) < .001 ? throw new DivideByZeroException() : this.left.Calculate() / r;
    }
}
