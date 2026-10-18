public class Solution {
    public int CalPoints(string[] operations) {
        var scores = new Stack<int>();

        foreach(string operation in operations)
        {
            switch(operation)
            {
                case "+":
                if(scores.Count == 1)
                {
                    scores.Push(scores.Peek());
                }
                int previous = scores.Pop();
                int next = previous + scores.Peek();
                scores.Push(previous);
                scores.Push(next);
                    break;
                case "D":
                scores.Push(scores.Peek()*2);
                    break;
                case "C":
                scores.Pop();
                    break;
                default:
                scores.Push(int.Parse(operation));
                    break;
            }
        }
        int sum=0;
        while(scores.Count > 0)
        {
            sum += scores.Pop();
        }
        return sum;
    }
}