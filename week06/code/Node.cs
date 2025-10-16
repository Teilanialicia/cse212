public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else if (Left.Data != value)
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else if (Right.Data != value)
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (Data == value)
            return true;
        else
        {
            if (Left is not null && value < Data)
            {
                return Left.Contains(value);
            }

            if (Right is not null && value > Data)
            {
                return Right.Contains(value);
            }
        }
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight = 0;
        int rightHeight = 0;

        if (Left != null)
            leftHeight = Left.GetHeight();

        if (Right != null)
            rightHeight = Right.GetHeight();

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}