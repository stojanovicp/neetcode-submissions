public class Solution {
    public int LastStoneWeight(int[] stones) {
        var maxHeap = new PriorityQueue<int,int>();
        foreach(int s in stones)
            maxHeap.Enqueue(s,-s);
        
        while(maxHeap.Count > 1)
        {
            int y = maxHeap.Dequeue();
            int x = maxHeap.Dequeue();
            y = y - x;
            maxHeap.Enqueue(y,-y);
        }
        return maxHeap.Dequeue();
    }
}
