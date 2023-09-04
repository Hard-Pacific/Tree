namespace Tree;

/// <summary>
/// Defines a substract operator.
/// </summary>
internal class Minus : Operator
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Minus"/> class.
    /// </summary>
    /// <param name="left">Left child tree node.</param>
    /// <param name="right">Right child tree node.</param>
    public Minus(ITreeNode left, ITreeNode right)
        : base(left, right)
    {
        this.op = '-';
    }

    /// <inheritdoc/>
    public override double Calculate()
        => this.left.Calculate() - this.right.Calculate();
}
