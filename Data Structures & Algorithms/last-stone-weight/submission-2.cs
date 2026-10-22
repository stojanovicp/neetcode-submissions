public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> maxHeap = new();

        foreach(int stone in stones)
            maxHeap.Enqueue(stone,-stone);

        while(maxHeap.Count > 1)
        {
            int first = maxHeap.Dequeue();
            int second = maxHeap.Dequeue();

            int smashed = first - second;

            if(smashed != 0)
                maxHeap.Enqueue(smashed, -smashed);
        }

        if(maxHeap.Count == 0)
            return 0;
        
        return maxHeap.Dequeue();
    }
}
