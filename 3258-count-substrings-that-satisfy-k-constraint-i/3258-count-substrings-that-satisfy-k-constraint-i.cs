public class Solution {
    public int CountKConstraintSubstrings(string s, int k) {
        int n = s.Length;
        int totalCount = 0;

        for (int start = 0; start < n; start++) {
            int count0 = 0, count1 = 0;
            for (int end = start; end < n; end++) {
                if (s[end] == '0') 
                    count0++;
                else 
                    count1++;

                // If the substring does not satisfy the k-constraint, break
                if (count0 > k && count1 > k) 
                    break;

                totalCount++;
            }
        }

        return totalCount;
    }
}