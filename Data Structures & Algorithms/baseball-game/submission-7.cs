public class Solution {
    public int CalPoints(string[] operations) {
        var scores = new Stack<int>();
        int sum = 0;
        foreach(string operation in operations)
        {
            switch(operation)
            {
                case "+":
                {
                    int lastScore = scores.Pop();
                    int newScore = lastScore + scores.Peek();
                    scores.Push(lastScore);
                    scores.Push(newScore);
                    sum += newScore;
                    break;
                }
                case "D":
                {
                    int newScore = scores.Peek() * 2;
                    scores.Push(newScore);
                    sum += newScore;
                    break;
                }
                case "C":
                {
                    int lastScore = scores.Pop();
                    sum -= lastScore;
                    break;
                }
                default:
                {
                    int newScore = Int32.Parse(operation);
                    scores.Push(newScore);
                    sum += newScore;
                    break;
                }
            }
        }
        return sum;
    }
}