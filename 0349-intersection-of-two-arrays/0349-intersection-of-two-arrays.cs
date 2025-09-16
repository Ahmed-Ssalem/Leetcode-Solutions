public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        
        Array.Sort(nums1);
        Array.Sort(nums2);
        HashSet<int> res = new HashSet<int>();

        foreach (int num1 in nums1)
            foreach (int num2 in nums2)     
                if (num1 == num2)
                {
                    res.Add(num1);
                    break;
                }
          
        return res.ToArray();
    }
}