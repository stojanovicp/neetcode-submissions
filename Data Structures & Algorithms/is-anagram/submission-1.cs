public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        Dictionary<char,int> charCounts = new();

        foreach(char character in s)
        {
            if(!charCounts.TryAdd(character, 1))
                charCounts[character]++;
        }

        foreach(char character in t)
        {
            if(!charCounts.ContainsKey(character))
                return false;

            charCounts[character]--;
            
            if (charCounts[character] < 0)
                return false;
        }
        
        return true;
    }
}
