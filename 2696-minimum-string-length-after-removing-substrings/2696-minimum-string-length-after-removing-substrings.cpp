class Solution {
public:
    int minLength(string s) {
        
        stack<char> stk;

        for (char c : s){
            if (stk.empty())
                stk.push(c);
            else{
                string compare = string(1, stk.top()) + string(1, c);
                if (compare == "AB" || compare == "CD")
                    stk.pop();
                else 
                    stk.push(c);
            }
        }

        return stk.size();
    }
};