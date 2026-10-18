public class Solution {
    public int CalPoints(string[] operations) {
        var record = new Stack<int>();
        int sum = 0;
        foreach(string operation in operations)
        {
            switch(operation)
            {
                case "+":
                {
                    int lastScore = record.Pop();
                    int newScore = lastScore + record.Peek();
                    record.Push(lastScore);
                    record.Push(newScore);
                    sum += newScore;
                    break;
                }
                case "D":
                {
                    int newScore = record.Peek() * 2;
                    record.Push(newScore);
                    sum += newScore;
                    break;
                }
                case "C":
                {
                    int lastScore = record.Pop();
                    sum -= lastScore;
                    break;
                }
                default:
                {
                    int newScore = Int32.Parse(operation);
                    record.Push(newScore);
                    sum += newScore;
                    break;
                }
            }
        }
        return sum;
    }
}