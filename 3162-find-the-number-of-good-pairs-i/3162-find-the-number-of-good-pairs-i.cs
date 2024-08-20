public class Solution {
    public int NumberOfPairs(int[] nums1, int[] nums2, int k) {

        Dictionary<int, int> countDict = new Dictionary<int, int>();

        foreach (var num in nums2){
            var key = num * k;
            if (!countDict.ContainsKey(key))
                countDict[key] = 0;
            countDict[key]++;
        }

        var goodPairs = 0;

        foreach (var num in nums1)
            foreach (var key in countDict.Keys)
                if (num % key == 0)
                    goodPairs++;
            

        return goodPairs;

        /*
        var res = 0;

        for (var i = 0; i < nums1.Length; ++i)
            for (var j = 0; j < nums2.Length; ++j)
                res += nums1[i] % (nums2[j] * k) == 0 ? 1 : 0;

        return res;
        */
    }
}