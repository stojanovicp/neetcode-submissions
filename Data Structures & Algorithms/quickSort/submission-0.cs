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
        return QuickSortR(pairs, 0, pairs.Count - 1);
    }

    private List<Pair> QuickSortR(List<Pair> pairs, int s, int e)
    {
        if(e - s + 1 <= 1)
            return pairs;

        Pair pivot = pairs[e];
        int left = s;

        for(int i = left; i < e; i++)
        {
            if(pairs[i].Key < pivot.Key)
            {
                Pair temp = pairs[i];
                pairs[i] = pairs[left];
                pairs[left] = temp;
                left++;
            }
        } 

        pairs[e] = pairs[left];
        pairs[left] = pivot;

        QuickSortR(pairs,s,left-1);
        QuickSortR(pairs,left+1,e);

        return pairs;
    }
}
