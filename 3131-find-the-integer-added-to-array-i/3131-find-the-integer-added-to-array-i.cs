public class Solution {
    public int AddedInteger(int[] nums1, int[] nums2) {
        
        Array.Sort(nums1);
        Array.Sort(nums2);

        return nums2[0] - nums1[0];

    }
}