public class MinStack {
    private readonly Stack<(int Val, int Min)> _stack;

    public MinStack()
    {
        _stack = new Stack<(int Val, int Min)>();
    }

    public void Push(int Val)
    {
        if(_stack.Count == 0)
        {
            _stack.Push((Val, Val));
        }
        else
        {
            int lastMin = _stack.Peek().Min;
            int newMin = Math.Min(lastMin, Val);
            _stack.Push((Val, newMin));
        }
    }

    public void Pop()
    {
        _stack.Pop();
    }

    public int Top()
    {
        return _stack.Peek().Val;
    }

    public int GetMin()
    {
        return _stack.Peek().Min;
    }
}