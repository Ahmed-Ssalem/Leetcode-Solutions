class Solution {
public:
    int maxDepth(string s) {
        
        int count = 0, res = 0;
        stack<char> stk;

        for (char c : s){
            if (c == '(')
                stk.push(c);
            else if (c == ')')
                stk.pop();

            count = stk.size();   
            res = max(count, res);
        }

        return res;
    }
};