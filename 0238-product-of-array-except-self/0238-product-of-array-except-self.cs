public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int n = nums.Length;
        int [] prefix = new int[n];
        int [] postfix = new int[n];
        int [] res = new int[n];

        prefix[0] = nums[0];
        postfix[n-1] = nums[n-1];

        for (int i = 1; i < n; ++i) 
            prefix[i] = nums[i] * prefix[i-1];
        
        for (int i = n - 2; i > 0; --i){
            postfix[i] = nums[i] * postfix[i+1];
        }

        for (int i = 0; i < n; ++i){
            int left = i > 0 ? prefix[i-1] : 1;
            int right= i < n - 1 ? postfix[i+1] : 1;
            res[i] = left * right; 
        }

        return res;
        
        // int[] res = new int[nums.Length];

        // int mul = 1;
        // for (int i = 0; i < nums.Length; ++i){
        //     res[i] = mul;
        //     mul *= nums[i];
        // }

        // mul = 1;
        // for (int i = nums.Length - 1; i >= 0; --i){
        //     res[i] *= mul;
        //     mul *= nums[i];
        // }
        
        // return res;

        /*
        int[] res = new int[nums.Length];
        Array.Fill(res, 0);
        int zeroes = 0, product = 1;

        for (int i = 0; i < nums.Length; ++i){
           if (nums[i] == 0)
                zeroes++;
            else
                product *= nums[i];        
        }

        if (zeroes == 1 )
            for (int i = 0; i < nums.Length; ++i)
                res[i] = nums[i] == 0 ? product : 0;

        else if (zeroes == 0)
            for (int i = 0; i < nums.Length; ++i)
                res[i] = product / nums[i];
        
            
        return res;
        */
    }
}