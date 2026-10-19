public class MyNode
{
    public int val;
    public MyNode next;
    public MyNode prev;

    public MyNode(int val)
    {
        this.val = val;
        next = null;
        prev = null;
    }
    public MyNode()
    {
        next = null;
        prev = null;
    }
}
public class MyLinkedList {
    MyNode head;
    MyNode tail;

    public MyLinkedList() {
        head = new MyNode();
        tail = new MyNode();
        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int index) {
        MyNode curr = this.head.next; 
        if (index < 0 || curr == tail)
        return -1;

        for(int i=0; i < index; i++)
        {
            curr = curr.next;
            if (curr == tail)
                return -1;
        }
        return curr.val;
    }
    
    public void AddAtHead(int val) {
        MyNode newNode = new MyNode(val);
        newNode.next = head.next;
        head.next.prev = newNode;
        head.next = newNode;
        newNode.prev = head;
    }
    
    public void AddAtTail(int val) {
        MyNode newNode = new MyNode(val);
        newNode.prev = tail.prev;
        newNode.next = tail;
        tail.prev.next = newNode;
        tail.prev = newNode;
    }
    
    public void AddAtIndex(int index, int val) {
        if (index < 0)
            index = 0;

        MyNode curr = this.head;
        if (curr == tail)
            return;

        for(int i=0; i < index; i++)
        {
            curr = curr.next;
            if (curr == tail)
                return;
        }
        MyNode newNode = new MyNode(val);
        newNode.next = curr.next;
        newNode.prev = curr;
        curr.next.prev = newNode;
        curr.next = newNode;
    
    }
    
    public void DeleteAtIndex(int index) {
        MyNode curr = this.head.next; 
        if (index < 0 || curr == tail) return;
        for(int i=0; i < index; i++)
        {
            curr = curr.next;
            if (curr == tail)
                return;
        }
        curr.prev.next = curr.next;
        curr.next.prev = curr.prev;
        
    }
}