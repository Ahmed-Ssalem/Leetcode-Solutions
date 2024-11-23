public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int codeLength = code.Length;
        
        int[] decryptedCode = new int[codeLength];
        
        // If k is 0, return an array of zeros
        if (k == 0) return decryptedCode;
        
        // Initialize the left pointer (windowStart) and the current window sum
        int windowStart = 0;
        int currentWindowSum = 0;
        
        // Loop over all elements and calculate the sliding window sum
        for (int windowEnd = 0; windowEnd < codeLength + Math.Abs(k); windowEnd++) {
            // Add the current element to the window sum
            currentWindowSum += code[windowEnd % codeLength];
            
            // If the window size exceeds the absolute value of k, remove the element at windowStart
            if (windowEnd - windowStart + 1 > Math.Abs(k)) {
                currentWindowSum -= code[windowStart % codeLength];
                windowStart = (windowStart + 1) % codeLength;
            }
            
            // If the window size is exactly equal to the absolute value of k, update the result
            if (windowEnd - windowStart + 1 == Math.Abs(k)) {
                if (k > 0) {
                    decryptedCode[(windowStart - 1 + codeLength) % codeLength] = currentWindowSum;
                } else {
                    decryptedCode[(windowEnd + 1) % codeLength] = currentWindowSum;
                }
            }
        }
        return decryptedCode;
    }
}
