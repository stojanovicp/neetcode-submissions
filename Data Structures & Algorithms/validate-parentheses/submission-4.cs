public class Solution {
    public bool IsValid(string s) {
        if(s.Length == 0) return true;

        Stack<char> stack = new Stack<char>();

        for(int i = 0; i < s.Length ; i++)
        {
            if(IsOpening(s[i]))
            {
                stack.Push(s[i]);
            }
            else
            {
                if(stack.Count == 0 || !IsClosed(stack.Pop(), s[i]))
                    return false;
            }
        }
        if(stack.Count == 0)
            return true;
        else
            return false;
    }
    public bool IsOpening(char c)
    {
        return c == '[' || c == '{' || c == '(';
    }
    public bool IsClosed(char open, char closed)
    {
        return (open == '[' && closed == ']') || (open == '{' && closed == '}') || (open == '(' && closed == ')');
    }
}
