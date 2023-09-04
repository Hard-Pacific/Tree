namespace Tree;

/// <summary>
/// A node of a tree structure.
/// </summary>
internal interface ITreeNode
{
    /// <summary>
    /// Calculates its value depending on it's child values.
    /// </summary>
    /// <returns>A value of the node.</returns>
    public double Calculate();

    /// <summary>
    /// Draws the node on the console.
    /// </summary>
    /// <param name="offset">Margin from the left side of the console.</param>
    public void Draw(int offset);
}
