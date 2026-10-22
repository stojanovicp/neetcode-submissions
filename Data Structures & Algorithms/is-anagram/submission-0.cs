public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        Dictionary<char,int> counterOfChars = new();
        foreach(char character in s)
        {
            if(!counterOfChars.TryAdd(character, 1))
                counterOfChars[character]++;
        }
        bool match = false;
        foreach(char character in t)
        {
            if(counterOfChars.ContainsKey(character))
            {
                match = false;
                counterOfChars[character]--;
                if(counterOfChars[character] < 0)
                    return false;
                if(counterOfChars[character] == 0)
                    match = true;
            }
            else
                return false;
        }
        
        return match;
    }
}
