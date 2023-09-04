namespace Tree;

/// <summary>
/// Defines a multiplication operator.
/// </summary>
internal class Multiply : Operator
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Multiply"/> class.
    /// </summary>
    /// <param name="left">Left child tree node.</param>
    /// <param name="right">Right child tree node.</param>
    public Multiply(ITreeNode left, ITreeNode right)
        : base(left, right)
    {
        this.op = '*';
    }

    /// <inheritdoc/>
    public override double Calculate()
        => this.left.Calculate() * this.right.Calculate();
}
