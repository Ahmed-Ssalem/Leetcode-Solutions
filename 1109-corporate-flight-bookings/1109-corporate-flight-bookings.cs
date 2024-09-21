public class Solution {
    public int[] CorpFlightBookings(int[][] bookings, int n) {
        
        var res = new int[n];

        foreach (var b in bookings)
        {
            var first = b[0] - 1;
            var last = b[1];
            var seats = b[2];

            res[first] += seats;

            if (last < n)
                res[last] -= seats; 
        }

        for (int i = 1; i < n; ++i)
            res[i] += res[i-1];

        return res;
    }
}