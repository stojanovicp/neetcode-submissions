public class Solution {
    public bool IsValid(string s) {
        var matchingBrackets = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };
        var openBrackets = new Stack<char>();

        foreach(char bracket in s)
        {
            if(matchingBrackets.ContainsKey(bracket))
            {
                openBrackets.Push(bracket);
            }
            else if(openBrackets.Count == 0 || bracket != matchingBrackets[openBrackets.Pop()])
            {
                return false;
            }
        }
        return openBrackets.Count == 0;
    }
}
