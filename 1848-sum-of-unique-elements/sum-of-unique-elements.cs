public class Solution {
    public int SumOfUnique(int[] nums) {
        
        int sum = 0, len = nums.Length; 
        
        for (int i = 0; i < len; ++i){
            
            int current = nums[i];
            bool isUnique = true;
            
            for (int j = 0; j < len; ++j)
                if (i != j && current == nums[j]){
                    isUnique = false;
                    break;
                }
            

            if (isUnique)
                sum += current;
        }

        return sum;
    }
}