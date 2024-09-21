public class Solution {
    public int WaysToMakeFair(int[] nums) {
        
        int len = nums.Length, totalEven = 0, totalOdd = 0;
        
        for (int i = 0; i < len; ++i)
        {
            if (i % 2 == 0)
                totalEven += nums[i];
            else
                totalOdd += nums[i];
        }

        int leftEven = 0, leftOdd = 0, count = 0;

        for (int i = 0; i < len; ++i)
        {
            if (i % 2 == 0)
                totalEven -= nums[i];
            else
                totalOdd -= nums[i];
            
            if (leftEven + totalOdd == leftOdd + totalEven)
                count++;
            
            if (i % 2 == 0)
                leftEven += nums[i];
            else
                leftOdd += nums[i];
        }
        return count;
    }
}
