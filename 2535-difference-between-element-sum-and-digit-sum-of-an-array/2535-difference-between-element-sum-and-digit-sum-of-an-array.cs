public class Solution {
    public int DifferenceOfSum(int[] nums) {
        
        int sum = 0, digitSum = 0;

        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];

            if (nums[i] > 9)
                while (nums[i] > 0)
                {
                    digitSum += nums[i] % 10;
                    nums[i] /= 10;
                }
            
            else 
                digitSum += nums[i];
        }

        return Math.Abs(sum - digitSum);
    }
}