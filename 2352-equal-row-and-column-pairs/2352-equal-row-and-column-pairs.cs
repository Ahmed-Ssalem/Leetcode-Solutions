public class Solution {
    public int EqualPairs(int[][] grid) {

        var res = 0; 
        var len = grid.Length;
        var row = new Dictionary<string, int>();
        var column = new Dictionary<string, int>();
        
        for (int i = 0; i < len; ++i)
        {
            var rowString = "";
            var colString = "";

            for (int j = 0; j < len; ++j)
            {
                rowString += "," + grid[i][j].ToString();
                colString += "," + grid[j][i].ToString();
            }

            if(!row.ContainsKey(rowString))
                row[rowString] = 1;
            else
                row[rowString]++;
                
            if(!column.ContainsKey(colString))
                column[colString] = 1;
            else
                column[colString]++;
        }

        foreach (var r in row)
            if (column.ContainsKey(r.Key))
                res += row[r.Key] * column[r.Key];
        
        return res;
    }
}