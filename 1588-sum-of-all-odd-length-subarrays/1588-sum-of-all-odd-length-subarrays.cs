public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        
        int len = arr.Length, res = 0;
        var prefix = new int[len+1];
        prefix[0] = arr[0];

        for (int i = 0; i < len; ++i)
        {
            res += arr[i];
            prefix[i+1] = prefix[i] + arr[i];
        }

        for (int i = 3; i <= len; ++i)
        {
            int right = i;

            for (int left = i - 3; left >= 0; left -= 2)
                res += prefix[right] - prefix[left];    
            
        }


        return res;        
    }
}