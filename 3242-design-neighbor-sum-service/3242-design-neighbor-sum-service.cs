public class neighborSum {
    
    private int[][] grid;
    private int n;

    public neighborSum(int[][] grid) {
        this.grid = grid;
        this.n = grid.GetLength(0);
    }
    
    public int AdjacentSum(int value) {
        
        int sum = 0;
        int[] pos = findPosition(value);

        if (pos == null){
            return sum;
        }

        int i = pos[0];
        int j = pos[1];
        
        if (i > 0)
            sum += grid[i-1][j];

        if (i < n - 1)
            sum += grid[i+1][j];

        if (j > 0)
            sum += grid[i][j-1];
        
        if (j < n - 1 )
            sum += grid[i][j+1];
        
        return sum;
    }
        
    
    public int DiagonalSum(int value) {

        int sum = 0;
        int[] pos = findPosition(value);

        if (pos == null){
            return sum;
        }

        int i = pos[0];
        int j = pos[1];
 
        if (i > 0 && j > 0)  
            sum += grid[i-1][j-1];

        if (i > 0 && j < n-1) 
             sum += grid[i-1][j+1];

        if (i < n-1 && j > 0) 
            sum += grid[i+1][j-1]; 
        
        if (i < n-1 && j < n-1)
            sum += grid[i+1][j+1];

        return sum;
    }

    private int[] findPosition(int value) {

        for (int i = 0; i < n; i++) 
            for (int j = 0; j < n; j++) 
                if (grid[i][j] == value) 
                    return new int[]{i, j};
                
        return null; 
    }
    
}

/**
 * Your neighborSum object will be instantiated and called as such:
 * neighborSum obj = new neighborSum(grid);
 * int param_1 = obj.AdjacentSum(value);
 * int param_2 = obj.DiagonalSum(value);
 */