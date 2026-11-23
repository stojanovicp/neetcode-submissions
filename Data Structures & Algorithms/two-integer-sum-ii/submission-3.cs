public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length-1;
        int[] result = new int[2];

        while(left < right)
        {
            int currentSum = numbers[left] + numbers[right];

            if(currentSum < target)
            {
                left++;
            }
            else if(currentSum > target)
            {
                right--;
            }
            else
            {
                result[0] = left + 1;
                result[1] = right + 1;
                break;
            }
        }
        return result;
    }
}
