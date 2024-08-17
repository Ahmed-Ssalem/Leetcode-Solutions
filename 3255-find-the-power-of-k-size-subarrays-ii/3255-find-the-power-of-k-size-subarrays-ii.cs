public class Solution {
    public int[] ResultsArray(int[] nums, int k) {
        
         int n = nums.Length;
        int[] results = new int[n - k + 1];
        int maxElement = int.MinValue;
        bool isValid = true;

        // Initialize the first window
        for (int i = 0; i < k; i++) {
            if (i > 0 && nums[i] != nums[i - 1] + 1) {
                isValid = false;
            }
            maxElement = Math.Max(maxElement, nums[i]);
        }
        results[0] = isValid ? maxElement : -1;

        // Slide the window
        for (int i = 1; i <= n - k; i++) {
            // Check if the new element breaks the consecutiveness
            if (nums[i + k - 1] != nums[i + k - 2] + 1) {
                isValid = false;
            }

            // Check if the old element was the reason the subarray was invalid
            if (nums[i] != nums[i - 1] + 1) {
                isValid = true;
                maxElement = nums[i];
                for (int j = i; j < i + k; j++) {
                    if (j > i && nums[j] != nums[j - 1] + 1) {
                        isValid = false;
                        break;
                    }
                    maxElement = Math.Max(maxElement, nums[j]);
                }
            } else {
                maxElement = Math.Max(maxElement, nums[i + k - 1]);
            }

            results[i] = isValid ? maxElement : -1;
        }

        return results;
    }
}