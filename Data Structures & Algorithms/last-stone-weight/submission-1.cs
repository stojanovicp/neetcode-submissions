public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> nextToSmash = new();

        foreach(int stone in stones)
            nextToSmash.Enqueue(stone,-stone);

        while(nextToSmash.Count > 1)
        {
            int first = nextToSmash.Dequeue();
            int second = nextToSmash.Dequeue();

            int smashed = first - second;

            if(smashed != 0)
                nextToSmash.Enqueue(smashed, -smashed);
        }

        if(nextToSmash.Count == 0)
            return 0;
        
        return nextToSmash.Dequeue();
    }
}
