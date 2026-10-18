public class KthLargest {
    private PriorityQueue<int,int> heap;
    private int _k;
    public KthLargest(int k, int[] nums) {
        heap = new PriorityQueue<int,int>();
        _k=k;
        if(nums.Length>0)
        {
            foreach(int n in nums)
            {
                heap.Enqueue(n,n);
                if(heap.Count > k)
                    heap.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        heap.Enqueue(val,val);
        if(heap.Count > _k)
            heap.Dequeue();

        return heap.Peek();
    }
}
