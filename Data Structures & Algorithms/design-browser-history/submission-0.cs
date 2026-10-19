public class BrowserNode{
    public string val;
    public BrowserNode next;
    public BrowserNode prev;

    public BrowserNode(string val = "")
    {
        this.val = val;
    }
}

public class BrowserHistory {
    private readonly BrowserNode _head;
    private readonly BrowserNode _tail;
    private BrowserNode _current;


    public BrowserHistory(string homepage) {
        BrowserNode newNode = new BrowserNode(homepage);
        _head = new BrowserNode();
        _tail = new BrowserNode();

        newNode.prev = _head;
        newNode.next = _tail;

        _head.next = newNode;

        _tail.prev = newNode;

        _current = newNode;
    }
    
    public void Visit(string url) {
        BrowserNode newNode = new BrowserNode(url);

        _current.next = newNode;
        
        newNode.prev = _current;
        newNode.next = _tail;

        _tail.prev = newNode;

        _current = newNode;
    }
    
    public string Back(int steps) {
        while (steps > 0 && _current.prev != _head)
        {
            _current = _current.prev;
            steps--;
        }
        
        return _current.val;
    }
    
    public string Forward(int steps) {
        while (steps > 0 && _current.next != _tail)
        {
            _current = _current.next;
            steps--;
        }

        return _current.val;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */