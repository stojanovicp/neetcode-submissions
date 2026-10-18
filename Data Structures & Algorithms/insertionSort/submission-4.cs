// Definition for a pair
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
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        int n = pairs.Count;
        var res = new List<List<Pair>>();
        if(n==0) return res;
        res.Add(new List<Pair>(pairs));
        
        for(int i = 1; i < n; i++)
        {
            Pair cur = pairs[i];
            int j = i - 1;

            while(j >= 0 && cur.Key<pairs[j].Key)
            {
                pairs[j+1] = pairs[j];
                j--;
            }
            pairs[j+1] = cur;
            res.Add(new List<Pair>(pairs));
        }
        return res;
    }
}
