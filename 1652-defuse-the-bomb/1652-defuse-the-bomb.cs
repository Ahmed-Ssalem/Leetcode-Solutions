public class Solution {
    public int[] Decrypt(int[] code, int k) {
        
        int n = code.Length;  
        int[] res = new int[n];

        if (k == 0)
            return new int[n];

        for (int i = 0; i < n; ++i)
        {
            int sum = 0;
            if (k > 0)
            {
                for (int j = 1; j <= k; ++j)
                    sum += code[(i + j) % n];
                res[i] = sum;
            }
            else
            {
                for (int j = 1; j <= -k; ++j)
                    sum += code[(i - j + n) % n];
                res[i] = sum;
            }
        }
        return res;
    }
}