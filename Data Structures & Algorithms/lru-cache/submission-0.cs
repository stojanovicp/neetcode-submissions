public class LRUCache {
    private class Node
    {
        public int Key;
        public int Value;
        public Node Prev;
        public Node Next;

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    private readonly int _capacity;
    private readonly Dictionary<int, Node> _map;
    private readonly Node _head;
    private readonly Node _tail;

    public LRUCache(int capacity) {
        _capacity = capacity;
        _map = new Dictionary<int,Node>();

        _head = new Node(0, 0);
        _tail = new Node(0, 0);

        _head.Next = _tail;
        _tail.Prev = _head;
    }
    
    public int Get(int key) {
        if (!_map.TryGetValue(key, out var node))
            return -1;

        MoveToFront(node);
        return node.Value;
    }
    
    public void Put(int key, int value) {
        if(_map.ContainsKey(key))
        {
            var node = _map[key];
            node.Value = value;
            MoveToFront(node);
        }
        else
        {
            if(_map.Count == _capacity)
                RemoveLRU();

            var node = new Node(key, value);
            _map.Add(key,node);
            AddToFront(node);
        }
    }

    private void AddToFront(Node node)
    {
        node.Next = _head.Next;
        node.Prev = _head;

        _head.Next.Prev = node;
        _head.Next = node;
    }

    private void RemoveNode(Node node)
    {
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
    }

    private void MoveToFront(Node node)
    {
        RemoveNode(node);
        AddToFront(node);
    }

    private void RemoveLRU()
    {
        var lru = _tail.Prev;
        RemoveNode(lru);
        _map.Remove(lru.Key);
    }
}
