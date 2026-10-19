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
        if (index < 0)
        return -1;

        MyNode curr = this.head.next; 
        for(int i=0; i < index && curr!=tail; i++)
        {
            curr = curr.next;
        }
        if(curr != tail)
            return curr.val;
        return -1;
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
        for (int i = 0; i < index && curr != tail; i++)
        {
            curr = curr.next;
        }
        if (curr != tail && curr.next != null)
        {
            MyNode newNode = new MyNode(val);
            newNode.next = curr.next;
            newNode.prev = curr;
            curr.next.prev = newNode;
            curr.next = newNode;
        }
    }
    
    public void DeleteAtIndex(int index) {
        if (index < 0) return;
        MyNode curr = this.head.next; 
        for(int i=0; i < index && curr!=tail; i++)
        {
            curr = curr.next;
        }
        if(curr != tail)
        {
            curr.prev.next = curr.next;
            curr.next.prev = curr.prev;
        }
    }
}