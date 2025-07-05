public class Solution {
    public int FindLucky(int[] arr) {
        
        Dictionary<int, int> freq = new Dictionary<int, int>();
        int res = -1;

        foreach (int num in arr)
        {
            if (!freq.ContainsKey(num))
                freq[num] = 1;
            else
                freq[num]++;
        }

        foreach (var kvp in freq)
            if (kvp.Key == kvp.Value && kvp.Key > res)
                res = kvp.Key;
        
        return res;
    }
}