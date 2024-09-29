public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        
        // O(n) solution

        int res = 0, n = arr.Length;
        
        for (int i = 0; i < n; ++i)
            res += ((n - i) * (i + 1) + 1) / 2 * arr[i];
        
        return res;

        // with prefix sum O(n^2) solution

        /*
        int len = arr.Length, res = 0;
        var prefix = new int[len+1];

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
        */      
    }
}