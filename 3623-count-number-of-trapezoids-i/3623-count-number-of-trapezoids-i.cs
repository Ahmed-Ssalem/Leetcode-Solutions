public class Solution {
    public int CountTrapezoids(int[][] points) {

        const long MOD = 1_000_000_007;
        Dictionary<int, int> sameYPoints = new Dictionary<int, int>();

        for (int i = 0; i < points.Length; ++i)
        {
            if (sameYPoints.ContainsKey(points[i][1]))
                sameYPoints[points[i][1]]++;
            else
                sameYPoints[points[i][1]] = 1;
        }

        List<long> rips = new List<long>();

        foreach (var kvp in sameYPoints)
            if (kvp.Value > 1)
                rips.Add(((long)(kvp.Value - 1) * kvp.Value / 2) % MOD);
        
        long ans = 0;
        long sum = 0;
        
        foreach (var val in rips)
            sum = (sum + val) % MOD;
        
        foreach (var val in rips)
        {
            sum = (sum - val + MOD) % MOD; // remaining sum
            ans = (ans + (val * sum) % MOD) % MOD;
        }
            
        return (int)ans;
    }
}