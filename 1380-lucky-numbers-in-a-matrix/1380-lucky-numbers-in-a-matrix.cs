public class Solution {
    public IList<int> LuckyNumbers(int[][] matrix) {

        var minInRow = new List<int>();
        var maxInCol = new List<int>();

        for (int i = 0; i < matrix.Length; ++i)
        {
            int minValue = 100001;
            
            for (int j = 0; j < matrix[0].Length; ++j)
                minValue = minValue >= matrix[i][j] ? matrix[i][j] : minValue;
            
            minInRow.Add(minValue);
        }

         for (int i = 0; i < matrix[0].Length; ++i)
         {
            int maxValue = 0;

            for (int j = 0; j < matrix.Length; ++j)
                maxValue = maxValue <= matrix[j][i] ? matrix[j][i] : maxValue;
            
            maxInCol.Add(maxValue);
        }

        return minInRow.Intersect(maxInCol).ToList();
    }
}