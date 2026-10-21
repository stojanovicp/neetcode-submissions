public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],int> closestPoints = new();

        foreach(int[] point in points)
        {
            int distanceSquared = point[0]*point[0] + point[1]*point[1];
            closestPoints.Enqueue(point, -distanceSquared);
            if(closestPoints.Count > k)
                closestPoints.Dequeue();
        }

        int[][] result = new int[k][];

        for(int i = k-1; i >= 0; i--)
        {
            result[i] = closestPoints.Dequeue();
        }

        return result;
    }
}
