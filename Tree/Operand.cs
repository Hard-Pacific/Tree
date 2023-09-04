namespace Tree;

/// <summary>
/// A number tree node without child.
/// </summary>
internal class Operand : ITreeNode
{
    private readonly double value;

    /// <summary>
    /// Initializes a new instance of the <see cref="Operand"/> class.
    /// </summary>
    /// <param name="value">A number in operand.</param>
    public Operand(int value)
        => this.value = value;

    /// <inheritdoc/>
    public double Calculate()
        => this.value;

    /// <inheritdoc/>
    public void Draw(int offset)
    {
        for (int i = 0; i < offset; i++)
        {
            Console.Write('\t');
        }

        Console.WriteLine(this.value);
    }
}
