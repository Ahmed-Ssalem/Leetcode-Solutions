class Solution {
public:
    string interpret(string command) {
        string res = "", temp = "";
        unordered_map<string, string> m =
        {
            { "(al)" , "al"},
            { "()" , "o" }, 
            { "G" , "G" },
        };
        
        for (char c : command){
            temp += c;
            if (m.find(temp) != m.end()){
                res += m[temp];
                temp = "";
            }
        }
        
        return res;
    }
};