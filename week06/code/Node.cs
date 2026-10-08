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
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        else return;
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true; //we found a match
        }
        
        //if the value is less than the data, it is not equal, but it would be on the left side so we check

        if (value < Data)
        {
            if (Left is not null)
            {
                return Left.Contains(value); 
            }

        }
        // similarly, if it's greater than the data, we need to check the right side
        else
        {
            if (Right is not null)
            {
                return Right.Contains(value);
            }
        }

        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight; //store the height of the left side somewhere
        if (Left is null)
        {
            leftHeight = 0;
        } else
        {
            leftHeight = Left.GetHeight(); //check height of the left side
        }

        int rightHeight; //store the height of the right side somewhere

        if (Right is null)
        {
            rightHeight = 0;
        } else
        {
            rightHeight = Right.GetHeight(); //check height of the right side
        }

        int taller = Math.Max(leftHeight, rightHeight); //see if the left or the right is taller to get the height
        return taller + 1; //add one to the taller of the numbers to get the height
    }
}