public class Solution {
    public string SortSentence(string s) {
        
        var arr = s.Split(' ');
        var res = new string[arr.Length];

        for (int i = 0; i < arr.Length; ++i)
            res[(arr[i][arr[i].Length - 1] + '0' - 96) - 1] = arr[i].Substring(0, arr[i].Length - 1);        

        return string.Join(' ', res);
    }
}