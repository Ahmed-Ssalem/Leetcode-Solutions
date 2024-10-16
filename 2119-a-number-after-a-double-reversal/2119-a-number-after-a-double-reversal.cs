public class Solution {
    public bool IsSameAfterReversals(int num) {
        if (num % 10 == 0 && num != 0)
            return false;
        return true;
    }
}