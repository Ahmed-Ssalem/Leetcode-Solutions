public class Solution {
    public bool IncreasingTriplet(int[] nums) {

        if (nums.Length < 3)
            return false;

        var first = long.MaxValue;
        var second = long.MaxValue;

        foreach (var num in nums){
            if (first >= num)
                first = num;
            else if (second >= num)
                second = num;
            else {
                return true;
                break;
            }
        } 
        return false;
/*
        List<int> lis = new List<int>();

        foreach (int num in nums){
            
            int pos = lis.BinarySearch(num);
            
            if (pos < 0)
                pos = ~pos;
            
            if (pos == lis.Count)
                lis.Add(num);
            
            else
                lis[pos] = num;
            
            if (lis.Count == 3)
                break;
            
        }
        return lis.Count >= 3; 
*/
    }
}