public class Solution {
    public IList<IList<int>> FindMatrix(int[] nums) {
        
        List<IList<int>> res = new()
        {
            new List<int>()
        };
        int[] occurrence = new int[nums.Length + 1];
        int maxOccurrence = 0;

        foreach (int num in nums){
            int currentOccurrence = occurrence[num]++;
            if (currentOccurrence > maxOccurrence){
                maxOccurrence = currentOccurrence;
                res.Add(new List<int> {num});
            }
            else
                res[currentOccurrence].Add(num);
        }
        return res; 
    }
}