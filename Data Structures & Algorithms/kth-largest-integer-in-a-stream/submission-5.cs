public class KthLargest {
    private PriorityQueue<int,int> _minHeap;
    private int k;

    public KthLargest(int k, int[] nums) {
        _minHeap = new();
        this.k = k;
        foreach(int num in nums)
            Add(num);
    }
    
    public int Add(int val) {
        _minHeap.Enqueue(val,val);

        if(_minHeap.Count > k)
                _minHeap.Dequeue();

        return _minHeap.Peek();
    }
}
