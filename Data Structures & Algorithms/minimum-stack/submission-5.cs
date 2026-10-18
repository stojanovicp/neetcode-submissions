public class MinStack {
    Stack<int> stack;
    Stack<int> minStack;

    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        if(minStack.Count == 0)
        {
            minStack.Push(val);
            stack.Push(val);
        }
        else
        {
            stack.Push(val);
            minStack.Push(Math.Min(minStack.Peek(), val));
        }
    }

    public void Pop()
    {
        minStack.Pop();
        stack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}
