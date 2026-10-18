// Definition for a pair.
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }5 2 9 1 9
//52
//5 2
public class Solution {
    public List<Pair> MergeSort(List<Pair> pairs) {
        if (pairs.Count == 0)
            return new List<Pair>();
        return mergeSplit(pairs, 0, pairs.Count-1);
    }
    private List<Pair> mergeSplit(List<Pair> pairs, int left, int right)
    {
        if(left == right)
        {
            var res = new List<Pair>();
            res.Add(pairs[left]);
            return res;
        }

        int mid = (left + right) / 2;
        var L = mergeSplit(pairs, left, mid);
        var R = mergeSplit(pairs, mid + 1, right);
        
        return mergeSorted(L, R);
    }
    private List<Pair> mergeSorted(List<Pair> A, List<Pair> B)
    {
        List<Pair> list = new List<Pair>();
        int i = 0, j = 0;
        while(i < A.Count && j < B.Count)
        {
            if(A[i].Key <= B[j].Key)
            {
                list.Add(A[i++]);
            }
            else
            {
                list.Add(B[j++]);
            }
        }
        while(i<A.Count)
            list.Add(A[i++]);

        while(j<B.Count)
            list.Add(B[j++]);
            
        return list;
    }
}
