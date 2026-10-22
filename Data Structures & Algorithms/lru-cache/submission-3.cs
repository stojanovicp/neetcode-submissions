public class Node
{
    public int key;
    public int value;
    public Node prev;
    public Node next;
}
public class LRUCache {
    Dictionary<int,Node> cache;
    Node head;
    Node tail;
    int capacity;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        cache = new();
    }
    
    public int Get(int key) {
        if(!cache.ContainsKey(key))
            return -1;

        Node current = cache[key];

        RemoveNode(current);
        AddToTail(current);

        return current.value;
    }
    
    public void Put(int key, int value) {
        Node current;
        if(!cache.ContainsKey(key))
        {
            if(cache.Count == capacity)
            {
                cache.Remove(head.key);
                RemoveNode(head);
            }

            current = new();
            current.key = key;
            current.value = value;
        }
        else
        {
            current = cache[key];
            current.value = value;
            RemoveNode(current);
        }
        AddToTail(current);
        cache[key] = current;
    }

    private void RemoveNode(Node node)
    {
        if(node == head && node == tail)
        {
            tail = null;
            head = null;
        }
        else if(node == head)
        {
            head = head.next;
            head.prev = null;
        }
        else if(node == tail)
        {
            tail = tail.prev;
            tail.next = null;
        }
        else
        {
            node.next.prev = node.prev;
            node.prev.next = node.next;
        }
    }

    private void AddToTail(Node node)
    {
        node.next = null;
        node.prev = tail;

        if(tail == null)
            head = node;
        else
            tail.next = node;
        
        tail = node;
    }
}
