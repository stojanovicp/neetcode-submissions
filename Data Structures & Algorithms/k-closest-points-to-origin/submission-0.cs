public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var heap = new PriorityQueue<int[], double>();
        for(int i = 0; i < points.Length; i++)
        {
            int[] xy = points[i];
            double r = Math.Sqrt((double)xy[0]*xy[0] + (double)xy[1]*xy[1]);
            heap.Enqueue(xy, r);
        }
        var res = new int[k][];
        int count = 0;
        while(count < k)
        {
            res[count] = heap.Dequeue();
            count++;
        }
        return res;
    }
}