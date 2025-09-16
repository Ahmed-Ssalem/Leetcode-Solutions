public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        
        Array.Sort(nums1);
        Array.Sort(nums2);
        HashSet<int> res = new HashSet<int>();

        int i = 0, j =0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] == nums2[j])
            {
                res.Add(nums1[i]);
                ++i;
                ++j;
            }
            else if (nums1[i] < nums2[j])
                ++i;
            else 
                ++j;
        }  
                
          
        return res.ToArray();
    }
}