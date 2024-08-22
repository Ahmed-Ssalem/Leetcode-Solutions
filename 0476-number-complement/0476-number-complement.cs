public class Solution {
    public int FindComplement(int num) {
        
        string binary = Convert.ToString(num, 2);

        char[] complementArr = binary.ToCharArray();

        for (int i = 0; i < complementArr.Length; ++i)
            complementArr[i] = complementArr[i] == '1' ? '0' : '1' ;
        
        string complementString = new string(complementArr);

        int complement = (int) Convert.ToInt32(complementString, 2);

        return complement;
    }
/*
    private string ConvertIntToBinary (int intNum){
        string binaryNum = "";
        while (intNum > 0){
            binaryNum += intNum % 2;
            intNum /= 2;
        }
        return binaryNum;
    }

    private long ConvertBinaryToInt(string binaryNum)
    {
        long result = 0;
        long baseValue = 1;  // Start with the least significant bit

        // Iterate through the binary string from right to left
        for (int i = binaryNum.Length - 1; i >= 0; i--)
        {
            if (binaryNum[i] == '1')
                result += baseValue;
            
            baseValue *= 2;  // Move to the next power of 2
        }

        return result;
    }
*/
}