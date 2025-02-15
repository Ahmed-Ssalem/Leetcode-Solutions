class Solution {
public:
    string removeOuterParentheses(string s) {
        
        stack<char> stk;
        string res;

        for (char c : s)
        {
            if (c == '(') stk.push(c);
            if (stk.size() > 1) res += c;
            if (c == ')') stk.pop();
        }
        return res;
    }
};