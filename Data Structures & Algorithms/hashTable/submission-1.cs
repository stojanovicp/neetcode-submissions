public class Node
{
    public int key;
    public int value;
    public Node next;
}
public class HashTable {
    private int capacity;
    private int size;
    private Node[] buckets;

    public HashTable(int capacity) {
        buckets = new Node[capacity];
        size = 0;
        this.capacity = capacity;
    }

    public void Insert(int key, int value) {
        int index = Hash(key);

        Node current = buckets[index];

        while(current != null)
        {
            if(current.key == key)
            {
                current.value = value;
                return;
            }

            current = current.next;
        }

        Node newNode = new Node();

        newNode.key = key;
        newNode.value = value;

        newNode.next = buckets[index];

        buckets[index] = newNode;

        size ++;
        
        if (size * 2 >= capacity)
            Resize();
    }

    public int Get(int key) {
        int index = Hash(key);
        
        Node current = buckets[index];

        while(current != null)
        {
            if(current.key == key)
                return current.value;

            current = current.next;
        }

        return -1;
    }

    public bool Remove(int key) {
        int index = Hash(key);
        
        Node head = null;
        Node current = buckets[index];

        while(current != null)
        {
            if(current.key == key)
            {
                if(head == null)
                    buckets[index] = current.next;
                else
                    head.next = current.next;

                size--;
                return true;
            }

            head = current;
            current = current.next;
        }

        return false;
    }

    public int GetSize() {
        return size;
    }

    public int GetCapacity() {
        return capacity;
    }

    public void Resize() {
        Node[] oldBuckets = buckets;

        capacity = capacity * 2;
        buckets = new Node[capacity];

        foreach(Node bucket in oldBuckets)
        {
            Node current = bucket;

            while(current != null)
            {
                Node next = current.next;

                int newIndex = Hash(current.key);

                current.next = buckets[newIndex];
                buckets[newIndex] = current;

                current = next;
            }
        }
    }

    private int Hash(int key){
        return key % capacity;
    }
}
