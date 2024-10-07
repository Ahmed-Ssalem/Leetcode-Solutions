public class Solution {
    public int Maximum69Number (int num) {

        var numDigits = ConvertNumToItsDigits(num);
        
        for (int i = 0; i < numDigits.Length; ++i)
            if (numDigits[i] != 9)
            {
                numDigits[i] = 9;
                break;
            }
        
        return ConvertDigitsToNum(numDigits); 
    }



    public int[] ConvertNumToItsDigits (int num)
    {
        var digits = new List<int>();

        while (num > 0)
        {
            digits.Add(num % 10);
            num /= 10;
        }
        digits.Reverse();
        var digitsArr = digits.ToArray();
        return digitsArr;
    }

    public int ConvertDigitsToNum (int[] digits)
    {
        var num = 0;

        for (int i = 0; i < digits.Length; ++i)
            num = num * 10 + digits[i];
        
        return num;
    }

}