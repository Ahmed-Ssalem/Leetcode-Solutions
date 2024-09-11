public class Solution {
    public int LengthOfLIS(int[] nums) {
        
        List<int> lis = new List<int>();

        foreach (int num in nums){
            
            int pos = lis.BinarySearch(num);

            if (pos < 0)
                pos = ~pos;
            
            if (pos == lis.Count)
                lis.Add(num);
            
            else
                lis[pos] = num;
        }
        return lis.Count;
    }
}