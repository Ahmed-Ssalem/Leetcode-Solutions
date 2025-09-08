public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        
        for (int i = 1; i < n; ++i)
            if (IsNoZero(i) && IsNoZero(n - i))
                return new int[] {i, n - i};
        return new int[0];

    }

    private bool IsNoZero (int num)
    {
        while (num > 0)
        {
            if (num % 10 == 0)
                return false;
            num /= 10;
        }
        return true;
    }
}