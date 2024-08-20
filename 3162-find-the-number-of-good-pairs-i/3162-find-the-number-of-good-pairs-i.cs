public class Solution {
    public int NumberOfPairs(int[] nums1, int[] nums2, int k) {

        var res = 0;

        for (var i = 0; i < nums1.Length; ++i)
            for (var j = 0; j < nums2.Length; ++j)
                if (nums1[i] % (nums2[j] * k) == 0)
                    res++;
                

        return res;
    }
}