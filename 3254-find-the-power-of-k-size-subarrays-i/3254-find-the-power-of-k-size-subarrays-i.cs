public class Solution {
    public int[] ResultsArray(int[] nums, int k) {

        int n = nums.Length;
        int[] results = new int[n - k + 1];

        for (int i = 0; i <= n - k; i++) {
            bool isConsecutiveAndSorted = true;
            int maxElement = nums[i];
            
            for (int j = i + 1; j < i + k; j++) {
                if (nums[j] != nums[j - 1] + 1) {
                    isConsecutiveAndSorted = false;
                    break;
                }
                maxElement = Math.Max(maxElement, nums[j]);
            }

            results[i] = isConsecutiveAndSorted ? maxElement : -1;
        }

        return results;
    }
}