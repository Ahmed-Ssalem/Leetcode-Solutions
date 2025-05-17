public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        
        Dictionary<int,int> freq = new Dictionary<int, int>();
        int res = 0;
        
        foreach (int num in nums){
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        int maxValue = freq.Values.Max();
        
        foreach (KeyValuePair<int,int> pair in freq)
            if (pair.Value == maxValue)
                res += pair.Value;
        
        return res;
    }
}