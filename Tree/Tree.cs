namespace Tree;

/// <summary>
/// Expression tree implementation.
/// </summary>
public class Tree
{
    private readonly Operator head;

    /// <summary>
    /// Initializes a new instance of the <see cref="Tree"/> class.
    /// </summary>
    /// <param name="expression">The PPN expression.</param>
    public Tree(string expression)
    {
        string[] commands = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int index = 0;
        this.head = (this.Read(commands, 0, ref index) as Operator) !;
    }

    /// <summary>
    /// Draws tree structure in the console.
    /// </summary>
    public void DrawTree()
        => this.head.Draw(0);

    /// <summary>
    /// Recursively calculates expression value.
    /// </summary>
    /// <returns>Result of the calculation.</returns>
    public double Calculate()
        => this.head.Calculate();

    private ITreeNode Read(string[] commands, int indexIn, ref int indexOut)
    {
        char op = commands[indexIn][1];

        indexOut = indexIn + 2;
        ITreeNode left = commands[indexIn + 1][0] != '(' ? new Operand(int.Parse(commands[indexIn + 1])) : Read(commands, indexIn + 1, ref indexOut);
        ITreeNode right;

        if (commands[indexOut][0] != '(')
        {
            string rValue = commands[indexOut].Remove(commands[indexOut].Length - 1, 1);
            while (rValue.Length > 0)
            {
                if (rValue[rValue.Length - 1] == ')')
                {
                    rValue = rValue.Remove(rValue.Length - 1, 1);
                }
                else
                {
                    break;
                }
            }

            right = new Operand(int.Parse(rValue));
            indexOut++;
        }
        else
        {
            right = this.Read(commands, indexOut, ref indexOut);
        }

        ITreeNode node = op switch
        {
            '+' => new Plus(left, right),
            '-' => new Minus(left, right),
            '*' => new Multiply(left, right),
            '/' => new Divide(left, right),
            _ => throw new ArgumentException("Invalid operator"),
        };
        return node;
    }
}
