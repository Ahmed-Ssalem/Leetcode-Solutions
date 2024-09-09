public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; ++i){
            
            int leftMul = 1, rightMul = 1;
            // left nums
            for (int j = i + 1; j < nums.Length; ++j)
                leftMul *= nums[j];

            // right nums
            for (int j = 0; j < i; ++j)
                rightMul *= nums[j];

            res[i] = rightMul * leftMul;
            
        }
            
        return res;
    }
}