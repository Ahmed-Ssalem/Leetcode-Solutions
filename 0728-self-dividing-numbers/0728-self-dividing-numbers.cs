public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        IList<int> res = new List<int>();

        for (int i = left; i <= right; ++i)
        {
            var num = i;
            var valid = true;
            while (num > 0)
            {
                var digit = num % 10;
                if (digit == 0 || i % digit != 0)
                    valid = false;
                num /= 10;    
            }
            if (valid)
                res.Add(i);
        }
        return res;
    }
}