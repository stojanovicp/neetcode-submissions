public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],long> farthestFirst = new();

        foreach(int[] point in points)
        {
            long distanceSquared = Distance(point[0], point[1]);
            
            farthestFirst.Enqueue(point, -distanceSquared);

            if(farthestFirst.Count > k)
                farthestFirst.Dequeue();
        }

        int[][] result = new int[k][];

        for(int i = k-1; i >= 0; i--)
        {
            result[i] = farthestFirst.Dequeue();
        }

        return result;
    }
    private long Distance(int x, int y) => x * x + y * y;
}
