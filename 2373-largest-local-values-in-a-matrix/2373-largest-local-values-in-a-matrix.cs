public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        
        var len = grid.Length;
        int[][] maxLocal = new int[len-2][];

        for (int i = 0; i < len - 2; ++i){
            maxLocal[i] = new int[len-2];
            for (int j = 0; j < len - 2; ++j)
                maxLocal[i][j] = FindMaInSubmatrix(grid, i, j);
        }    
        return maxLocal;

    }
    private int FindMaInSubmatrix(int[][] grid, int row, int col){
        
        var max = -1;
        
        for (int i = row; i < row + 3; ++i)
            for (int j = col; j < col + 3; ++j)
                max = Math.Max(max, grid[i][j]);
            
        return max;
    }

}