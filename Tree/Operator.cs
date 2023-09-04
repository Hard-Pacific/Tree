namespace Tree;

/// <summary>
/// Operator tree node, calculates its value by its left and right child.
/// </summary>
internal class Operator : ITreeNode
{
    /// <summary>
    /// Left child tree node.
    /// </summary>
    protected ITreeNode left;

    /// <summary>
    /// Right child tree node.
    /// </summary>
    protected ITreeNode right;

    protected char op;

    /// <summary>
    /// Initializes a new instance of the <see cref="Operator"/> class.
    /// </summary>
    /// <param name="left">Left child tree node.</param>
    /// <param name="right">Right child tree node.</param>
    public Operator(ITreeNode left, ITreeNode right)
    {
        this.left = left;
        this.right = right;
    }

    /// <inheritdoc/>
    public virtual double Calculate()
        => throw new ArgumentException();

    /// <inheritdoc/>
    public void Draw(int offset)
    {
        if (this.left is not null)
        {
            this.left.Draw(offset + 1);
        }

        for (int i = 0; i < offset; i++)
        {
            Console.Write('\t');
        }

        Console.WriteLine(this.op);
        if (this.right is not null)
        {
            this.right.Draw(offset + 1);
        }
    }
}
