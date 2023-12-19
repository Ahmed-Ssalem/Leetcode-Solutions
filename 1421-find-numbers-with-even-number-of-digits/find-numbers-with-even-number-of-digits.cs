public class Solution {
    public int FindNumbers(int[] nums) {
        
        int res = 0;
        for (int i = 0; i < nums.Length; ++i){
            int count = 0;
            while (nums[i] >= 1){
                nums[i] /= 10;
                count++;
            }
            if (count % 2 == 0)
                res++;
        }

        return res;
    }
}