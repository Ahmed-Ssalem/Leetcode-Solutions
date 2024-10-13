public class Solution {
    public int HeightChecker(int[] heights) {
        
        int[] expected = (int[])heights.Clone();
        Array.Sort(expected);
        
        var res = 0;

        for (int i = 0; i < heights.Length; ++i)
            if(heights[i] != expected[i])
                res++;
        
        return res;

    }
}