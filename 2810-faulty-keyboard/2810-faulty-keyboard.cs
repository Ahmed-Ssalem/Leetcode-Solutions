public class Solution {
    public string FinalString(string s) {
        
        var list = new List<char>();

        foreach(var ch in s){
            if (ch != 'i')
                list.Add(ch);
            else
                list.Reverse();
        }
        return string.Concat(list);
    }
}