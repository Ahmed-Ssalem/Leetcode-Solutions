public class Solution {
    public string AddBinary(string a, string b) {

        int num1 = Convert.ToInt32(a, 2);
        int num2 = Convert.ToInt32(b, 2);
        int sum = num1 + num2;
        
        return Convert.ToString(sum, 2);
    }
}