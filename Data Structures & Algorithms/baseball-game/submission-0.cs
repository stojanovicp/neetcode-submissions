public class Solution {
    public int CalPoints(string[] operations) {
        List<int> scores = new List<int>();
        int lastScore = -1;
        for(int i = 0; i < operations.Length; i ++)
        {
            switch(operations[i])
            {
                case "+":
                scores.Add(scores[lastScore] + scores[lastScore-1]);
                lastScore++;
                    break;
                case "D":
                scores.Add(scores[lastScore]*2);
                lastScore++;
                    break;
                case "C":
                scores.RemoveAt(lastScore);
                lastScore--;
                    break;
                default:
                scores.Add(int.Parse(operations[i]));
                lastScore++; 
                    break;
            }
        }
        int sum=0;
        foreach(int score in scores)
        {
            sum+=score;
        }
        return sum;
    }
}