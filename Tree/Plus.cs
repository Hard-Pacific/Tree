namespace Tree;

/// <summary>
/// Defines a sum operator.
/// </summary>
internal class Plus : Operator
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Plus"/> class.
    /// </summary>
    /// <param name="left">Left child tree node.</param>
    /// <param name="right">Right child tree node.</param>
    public Plus(ITreeNode left, ITreeNode right)
        : base(left, right)
    {
        this.op = '+';
    }

    /// <inheritdoc/>
    public override double Calculate()
        => this.left.Calculate() + this.right.Calculate();
}
