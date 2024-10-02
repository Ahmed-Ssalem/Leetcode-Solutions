public class Solution {
    public int MinElement(int[] nums) {

        var numsDigitSum = new List<int>();
        

        for (int i = 0; i < nums.Length; ++i)
        {
            var sum = 0;

            while (nums[i] > 0)
            {
                sum += nums[i] % 10;
                nums[i] /= 10;
            }

            numsDigitSum.Add(sum);
        }

        return numsDigitSum.Min();
    }
}