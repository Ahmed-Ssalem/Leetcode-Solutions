public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
        
        var res = new int[1001];
        var min = 1001;
        var max = 0;

        foreach (var trip in trips)
        {
            res[trip[1]] += trip[0];   
            res[trip[2]] -= trip[0];

            if (trip[1] < min)
                min = trip[1];

            if (trip[2] > max)
                max = trip[2];
        }

        for (int i = 0; min <= max; ++min)
        {
            i += res[min];

            if (i > capacity)
                return false;
        }
            
        return true;
    }
}