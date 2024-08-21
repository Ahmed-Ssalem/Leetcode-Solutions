public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        
        string str1 = "", str2 = "";
        
        foreach (var word in word1)
            str1 += word;
        
        foreach (var word in word2)
            str2 += word;

        return str1 == str2 ? true : false;
    }
}