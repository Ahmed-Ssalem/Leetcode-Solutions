public class Solution {
    public long MaxPoints(int[][] points) {
        
        int m = points.Length; // Number of rows
        int n = points[0].Length; // Number of columns
        
        // Edge case: If there is only one row, return the maximum value in that row
        if (m == 1) return points[0].Max();
        
        // Initialize DP array with the first row
        int[] dp = new int[n];
        for (int j = 0; j < n; j++) {
            dp[j] = points[0][j];
        }
        
        // Iterate through each row starting from the second row
        for (int i = 1; i < m; i++) {
            // Create a temporary array to store the new DP values for the current row
            int[] newDp = new int[n];
            
            // Calculate the maximum points if you are picking any cell from the previous row
            int maxFromLeft = int.MinValue;
            int maxFromRight = int.MinValue;
            
            // Compute the maximum value from the left to right
            for (int j = 0; j < n; j++) {
                maxFromLeft = Math.Max(maxFromLeft, dp[j] + j); // Maximum value if coming from left side
                newDp[j] = points[i][j] - j + maxFromLeft; // Compute maximum points for this column
            }
            
            // Compute the maximum value from the right to left
            for (int j = n - 1; j >= 0; j--) {
                maxFromRight = Math.Max(maxFromRight, dp[j] - j); // Maximum value if coming from right side
                newDp[j] = Math.Max(newDp[j], points[i][j] + j + maxFromRight); // Compute maximum points for this column
            }
            
            // Update dp array with newDp values
            dp = newDp;
        }
        
        // The result is the maximum value in the last dp array
        return dp.Max();
    }
}