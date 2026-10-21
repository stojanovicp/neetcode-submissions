public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],int> closestPoints = new();

        foreach(int[] point in points)
        {
            int distanceSquared = point[0]*point[0] + point[1]*point[1];
            closestPoints.Enqueue(point, distanceSquared);
        }

        int[][] result = new int[k][];

        for(int i = 0; i < k; i++)
        {
            result[i] = closestPoints.Dequeue();
        }

        return result;
    }
}
