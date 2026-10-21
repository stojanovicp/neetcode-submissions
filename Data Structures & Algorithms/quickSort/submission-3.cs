// public class Pair {
//     public int Key;
//     public string Value; 
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> QuickSort(List<Pair> pairs) {
        QuickSortRecursive(pairs, 0, pairs.Count - 1);
        return pairs;
    }

    private void QuickSortRecursive(List<Pair> pairs, int left, int right)
    {
        if(left >= right)
        {
            return;
        }

        int partitionIndex = left;

        for(int i = left; i < right ; i++)
        {
            if(pairs[i].Key < pairs[right].Key)
            {
                (pairs[i], pairs[partitionIndex]) = (pairs[partitionIndex], pairs[i]);
                partitionIndex++;
            }
        }

        (pairs[right], pairs[partitionIndex]) = (pairs[partitionIndex], pairs[right]);

        QuickSortRecursive(pairs, left, partitionIndex-1);
        QuickSortRecursive(pairs, partitionIndex + 1, right);
    }
}