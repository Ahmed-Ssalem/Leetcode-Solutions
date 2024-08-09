public class Solution {

    public int StrStr(string haystack, string needle) {


        //return haystack.IndexOf(needle);
        
        var len1 = haystack.Length;
        var len2 = needle.Length;

        for (int i = 0; i <= len1 - len2; ++i){
            if (needle[0] == haystack[i]){
                bool check = true;
                for (int j = 1; j < len2; ++j){
                    if (needle[j] != haystack[i+j]){
                        check = false;
                        break;
                    }
                }  
                if (check) return i;
            }
        }
        return -1;
    }
}