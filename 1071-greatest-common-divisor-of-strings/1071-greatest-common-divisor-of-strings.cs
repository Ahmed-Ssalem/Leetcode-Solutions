public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        
        if (!(str1 + str2).Equals(str2 + str1))
            return "";
        
        int gcdLen = Gcd(str1.Length, str2.Length);
        
        return str1.Substring(0, gcdLen);

    }

    public int Gcd(int num1, int num2){
        while (num2 != 0){
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return num1;
    }
}