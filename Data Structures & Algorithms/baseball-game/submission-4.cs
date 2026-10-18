public class Solution {
    public int CalPoints(string[] operations) {
        var record = new Stack<int>();
        int sum = 0;
        foreach(string operation in operations)
        {
            switch(operation)
            {
                case "+":
                    int temp = record.Pop();
                    int score = temp + record.Peek();
                    record.Push(temp);
                    record.Push(score);
                    break;
                case "D":
                    record.Push(record.Peek() * 2);
                    break;
                case "C":
                    record.Pop();
                    break;
                default:
                    record.Push(Int32.Parse(operation));
                    break;

            }
        }
        while(record.Count > 0)
        {
           sum += record.Pop(); 
        }
        return sum;
    }
}