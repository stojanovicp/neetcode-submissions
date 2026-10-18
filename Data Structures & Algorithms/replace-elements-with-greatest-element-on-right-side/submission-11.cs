public class Solution {
    // public int[] ReplaceElements(int[] arr) {
    //     for(int i = 0; i <= arr.Length - 2; i++)
    //     {
    //         FindMaxOnRight(arr, i);
    //     }
    //     arr[arr.Length - 1] = -1;
    //     return arr;
    // }
    // public void FindMaxOnRight(int[] arr, int start)
    // {
    //     int max = arr[start + 1];
    //     for(int i = start+1; i <= arr.Length - 1; i++)
    //     {
    //         max = Math.Max(arr[i], max);
    //     }
    //     arr[start] = max;
    // }
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;
        int[] res = new int[n];
        int currentMax = -1;
        for(int i = n-1; i >= 0; i--)
        {
            res[i] = currentMax;
            currentMax = Math.Max(currentMax, arr[i]);
        }
        return res;
    }
}