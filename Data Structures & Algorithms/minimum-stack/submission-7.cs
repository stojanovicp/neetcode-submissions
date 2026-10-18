public class MinStack {
    Stack<(int val, int min)> stack;

    public MinStack()
    {
        stack = new Stack<(int val, int min)>();
    }

    public void Push(int val)
    {
        if(stack.Count == 0)
        {
            stack.Push((val, val));
        }
        else
        {
            int lastMin = stack.Peek().min;
            int newMin = Math.Min(lastMin, val);
            stack.Push((val, newMin));
        }
    }

    public void Pop()
    {
        stack.Pop();
    }

    public int Top()
    {
        return stack.Peek().val;
    }

    public int GetMin()
    {
        return stack.Peek().min;
    }
}