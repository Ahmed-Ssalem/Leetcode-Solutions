public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        int len = points.GetLength(0), res = -1;
        int[] xAxis = new int[len];
        for (int i = 0; i < len; ++i){
            xAxis[i] = points[i][0];
        }
        Array.Sort(xAxis);
        for (int i = 1; i < len; ++i)
            if (res < xAxis[i] - xAxis[i-1])
                res = xAxis[i] - xAxis[i-1];
        
        return res;
    }
}