public class MyNode
{
    public int val;
    public MyNode next;
    public MyNode prev;

    public MyNode(int val = 0)
    {
        this.val = val;
    }
}
public class MyLinkedList {
    private readonly MyNode _head;
    private readonly MyNode _tail;

    public MyLinkedList() {
        _head = new MyNode();
        _tail = new MyNode();
        _head.next = _tail;
        _tail.prev = _head;
    }
    
    public int Get(int index) {
        MyNode curr = this._head.next; 
        if (index < 0 || curr == _tail)
        return -1;

        for(int i=0; i < index; i++)
        {
            curr = curr.next;
            if (curr == _tail)
                return -1;
        }
        return curr.val;
    }
    
    public void AddAtHead(int val) {
        MyNode newNode = new MyNode(val);
        newNode.next = _head.next;
        _head.next.prev = newNode;
        _head.next = newNode;
        newNode.prev = _head;
    }
    
    public void AddAtTail(int val) {
        MyNode newNode = new MyNode(val);
        newNode.prev = _tail.prev;
        newNode.next = _tail;
        _tail.prev.next = newNode;
        _tail.prev = newNode;
    }
    
    public void AddAtIndex(int index, int val) {
        if (index < 0)
            index = 0;
        
        MyNode curr = this._head;

        for(int i=0; i < index; i++)
        {
            curr = curr.next;
            if (curr == _tail)
                return;
        }
        MyNode newNode = new MyNode(val);
        newNode.next = curr.next;
        newNode.prev = curr;
        curr.next.prev = newNode;
        curr.next = newNode;
    
    }
    
    public void DeleteAtIndex(int index) {
        MyNode curr = this._head.next; 
        if (index < 0 || curr == _tail) return;
        for(int i=0; i < index; i++)
        {
            curr = curr.next;
            if (curr == _tail)
                return;
        }
        curr.prev.next = curr.next;
        curr.next.prev = curr.prev;
        
    }
}