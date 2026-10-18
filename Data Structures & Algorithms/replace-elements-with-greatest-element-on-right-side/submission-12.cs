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
        int currentMax = -1;

        for(int i = arr.Length - 1; i >= 0; i--)
        {
            int temp = arr[i];
            arr[i] = currentMax;
            currentMax = Math.Max(currentMax, temp);
        }
        return arr;
    }
}