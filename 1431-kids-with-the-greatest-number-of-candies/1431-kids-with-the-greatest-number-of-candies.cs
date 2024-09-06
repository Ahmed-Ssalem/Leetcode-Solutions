public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {

        var maxNum = candies.Max();
        IList<bool> res = new List<bool>();
        
        for (var i = 0; i < candies.Length; ++i)
            if (candies[i] + extraCandies >= maxNum)
                res.Add(true);
            else
                res.Add(false);
        

        return res;


    }
}