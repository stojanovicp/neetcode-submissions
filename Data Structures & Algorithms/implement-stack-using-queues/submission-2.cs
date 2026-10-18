public class MyStack {
    private Queue<int> stack;
    private Queue<int> help;
    private int count;

    public MyStack() {
        stack = new Queue<int>();
        help = new Queue<int>();
        count = 0;
    }
    
    public void Push(int x) {
        help.Enqueue(x);
        while(stack.Count>0)
            help.Enqueue(stack.Dequeue());

        var temp = stack;
        stack = help;
        help = temp;

        count++;
    }
    
    public int Pop() {
        if(count == 0)
            throw new InvalidOperationException("Stack is empty");

        count--;        
        return stack.Dequeue();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public bool Empty() {
        return count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */