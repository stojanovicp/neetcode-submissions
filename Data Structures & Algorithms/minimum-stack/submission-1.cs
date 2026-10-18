public class MinStack {
    private Stack<(int val, int min)> stack;

    public MinStack() {
        stack = new Stack<(int,int)>();
    }
    
    public void Push(int val) {
        if (stack.Count == 0)
            stack.Push((val, val));
        else
        {
            int currentMin = stack.Peek().min;
            stack.Push((val, Math.Min(val, currentMin)));
        }
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().val;
    }
    
    public int GetMin() {
        return stack.Peek().min;
    }
}
