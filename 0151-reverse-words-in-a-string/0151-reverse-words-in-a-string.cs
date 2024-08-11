public class Solution {
    public string ReverseWords(string s) {
        
        List<string> words = new List<string>();
        string word = "";
        
        for (int i = 0; i < s.Length; ++i){
            if (s[i] != ' '){ 
                word += s[i];
            }
            else if (s[i] == ' ' && word != ""){
                words.Add(word);
                word = "";
            }
        }
        if (!string.IsNullOrEmpty(word))
            words.Add(word);

        var res = "";

        for (int i = words.Count - 1; i >= 0; --i){
            res += words[i];
            if (i != 0)
                res += " ";
        }

        return res;


        /*
        string[] split = s.Split(new char [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string res = "";
        for (int i = split.Length - 1; i >= 0; --i){
            res += split[i];
            if (i != 0)
                res += " ";
        }
        return res;
        */
    }
}