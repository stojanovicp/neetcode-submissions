public class BrowserNode{
    public string url;
    public BrowserNode next;
    public BrowserNode prev;

    public BrowserNode(string url = "")
    {
        this.url = url;
    }
}

public class BrowserHistory {
    private readonly BrowserNode _head;
    private readonly BrowserNode _tail;
    private BrowserNode _currentPage;


    public BrowserHistory(string homepage) {
        BrowserNode newPage = new BrowserNode(homepage);
        _head = new BrowserNode();
        _tail = new BrowserNode();

        newPage.prev = _head;
        newPage.next = _tail;

        _head.next = newPage;

        _tail.prev = newPage;

        _currentPage = newPage;
    }
    
    public void Visit(string url) {
        BrowserNode newPage = new BrowserNode(url);

        _currentPage.next = newPage;
        
        newPage.prev = _currentPage;
        newPage.next = _tail;

        _tail.prev = newPage;

        _currentPage = newPage;
    }
    
    public string Back(int steps) {
        while (steps > 0 && _currentPage.prev != _head)
        {
            _currentPage = _currentPage.prev;
            steps--;
        }
        
        return _currentPage.url;
    }
    
    public string Forward(int steps) {
        while (steps > 0 && _currentPage.next != _tail)
        {
            _currentPage = _currentPage.next;
            steps--;
        }

        return _currentPage.url;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */