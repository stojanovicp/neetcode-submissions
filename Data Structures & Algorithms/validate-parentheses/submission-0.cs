public class Solution {
    public bool IsValid(string s) {
        if(string.IsNullOrEmpty(s)) return true;
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(IsOpening(s[i]))
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count == 0)
                    return false;
                if(IsClosing(stack.Peek(), s[i]))
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }
        if (stack.Count == 0)
            return true;
        return false;
    }
    public bool IsOpening(char a)
    {
        return a == '(' || a == '{' || a == '[';
    }
    public bool IsClosing(char a, char b)
    {
        return (a == '(' && b == ')') || (a == '{' && b == '}') || (a == '[' && b == ']');
    }
}
