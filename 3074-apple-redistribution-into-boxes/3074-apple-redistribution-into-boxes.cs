public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        
        int sumOfApples = 0;
        int res = 0;
        Array.Sort(capacity);

        for (int i = 0; i < apple.Length; ++i)
            sumOfApples += apple[i];

        for (int i = capacity.Length - 1; i >= 0; --i)
        {
            if (sumOfApples > 0)
            {
                sumOfApples -= capacity[i];
                res++;
            }
        }

        return res;
    }
}