public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        
        var n1 = new HashSet<int>(nums1);
        var n2 = new HashSet<int>(nums2); 

        n1.ExceptWith(nums2);
        n2.ExceptWith(nums1);

        IList<IList<int>> res = new List<IList<int>>();

        res.Add(new List<int>(n1));
        res.Add(new List<int>(n2));
        
        return res;
    }
}