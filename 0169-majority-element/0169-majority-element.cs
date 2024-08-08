public class Solution {
    public int MajorityElement(int[] nums) {

        Dictionary<int,int> count = new Dictionary<int, int>();

        double appear = nums.Length / 2;

        foreach (var num in nums){
            if (!count.ContainsKey(num))
                count.Add(num, 1);
            else
                count[num]++;
        }

        foreach (var result in count)
            if (result.Value > appear)
                return result.Key;
        
        return 0;
        
    }
}