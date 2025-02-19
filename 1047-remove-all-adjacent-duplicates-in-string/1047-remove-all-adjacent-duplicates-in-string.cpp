class Solution {
public:
    string removeDuplicates(string s) {
        
        stack<char> stk;
        string res = "";

        for (char c : s){
            if (stk.empty() || stk.top() != c)
                stk.push(c);
            else if (stk.top() == c)
                    stk.pop();
        }

        while (!stk.empty()){
            res = stk.top() + res;
            stk.pop();
        }
        
        return res;
    }
};