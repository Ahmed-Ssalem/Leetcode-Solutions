class Solution {
public:
    int subtractProductAndSum(int n) {
        string s = to_string(n);
        int sum = 0, mul = 1;
        for (int i = 0; i < s.length(); ++i){
            sum += s[i] - '0';
            mul *= s[i] - '0';
        }
        return mul - sum;
    }
};