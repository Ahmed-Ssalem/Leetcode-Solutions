public class Solution {
    public int PivotInteger(int n) {
        
        var prefix = new int[n+1];
        var suffix = new int[n+1];

        prefix[1] = 1;
        suffix[n] = n;
        
        for (int i = 2, j = n - 1; i <= n && j > 0; ++i, --j)
        {
            prefix[i] = prefix[i-1] + i;
            suffix[j] = suffix[j+1] + j; 
        }
        
        
        
        for (int i = 1; i <= n; ++i)
            if (prefix[i] == suffix[i]) 
                return i;

        return -1;

    }
}