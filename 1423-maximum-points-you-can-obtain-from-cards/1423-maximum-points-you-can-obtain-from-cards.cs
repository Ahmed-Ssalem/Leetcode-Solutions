public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        
        int leftSum = 0, rightSum = 0, res = 0, n = cardPoints.Length;

        for (int i = 0; i < k; ++i)
            leftSum += cardPoints[i];
        
        res = leftSum;

        for (int i = k - 1, j = n - 1; i >= 0; --i, --j)
        {
            leftSum -= cardPoints[i];
            rightSum += cardPoints[j];
            res = Math.Max(res, leftSum + rightSum);
        }
        return res;
    }
}