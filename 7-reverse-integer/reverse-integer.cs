public class Solution {
    public int Reverse(int x) {
        
        var reversedNum = 0;

        while (x != 0){
            
            int reminder = x % 10;
            var testOverFlow = (reversedNum * 10) + reminder;
            
            if ((testOverFlow - reminder) / 10 != reversedNum)
                return 0;
            
            reversedNum = testOverFlow;
            x /= 10;
        }

        return reversedNum;
    }
}