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

        List<List<Pair>> sortingSteps = new List<List<Pair>>();
        if(pairs.Count == 0) return sortingSteps;
        
        for(int i = 0; i < pairs.Count; i++)
        {
            Pair currentPair = pairs[i];
            int j = i-1;

            while(j>=0 && currentPair.Key < pairs[j].Key)
            {
                pairs[j+1] = pairs[j];
                j--;
            }
            pairs[j+1]=currentPair;
            sortingSteps.Add(new List<Pair>(pairs));
        }
        return sortingSteps;
    }
}
