public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        
        var sneaky = new Dictionary<int, int>();
        var res = new List<int>();

        foreach (var num in nums)
            if (!sneaky.TryAdd(num, 1))
            {
                if (!res.Contains(num))
                    res.Add(num);

                sneaky[num]++;
            }
                    
            
        return res.ToArray();
    }
}