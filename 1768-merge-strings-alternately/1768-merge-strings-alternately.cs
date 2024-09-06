public class Solution {
    public string MergeAlternately(string word1, string word2) {



        var len = Math.Min(word1.Length, word2.Length);
        var lenDeff = word1.Length - word2.Length;
        var res = "";

        for (int i = 0; i < len; ++i){
            res += word1[i];
            res += word2[i];
        }

        if (lenDeff > 0)
            res += word1.Substring(lenDeff);
        else if (lenDeff < 0)
            res += word2.Substring(Math.Abs(lenDeff));

        return res;





    }
}