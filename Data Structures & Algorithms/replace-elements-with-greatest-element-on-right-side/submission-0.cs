public class Solution {
    public int[] ReplaceElements(int[] arr) {
        if(arr.Length == 0) return null;

        for(int i = 0; i < arr.Length - 1; i++)
        {
            int indexOfNextMax = FindIndexOfMax(arr, i + 1);
            for(int j = i; j < indexOfNextMax; j++)
            {
                arr[j] = arr[indexOfNextMax];
            }
            i = indexOfNextMax - 1;
        }
        arr[arr.Length - 1] = -1;
        return arr;
    }
    public int FindIndexOfMax(int[] arr, int start)
    {
        int indexOfMax = start;
        for(int i = start; i < arr.Length; i++)
        {
            if(arr[indexOfMax] <= arr[i])
                indexOfMax = i;
        }
        return indexOfMax;
    }
}