public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int L = 0, R = numbers.Length-1;
        int[] res = new int[2];
        while(L < R)
        {
            if(numbers[L] + numbers[R] == target)
            {
                res[0] = L+1;
                res[1] = R+1;
                return res;
            }
            else if(numbers[L] + numbers[R] < target)
            {
                L++;
            }
            else
            {
                R--;
            }
        }
        return res;
    }
}
