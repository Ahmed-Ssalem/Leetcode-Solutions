class Solution {
public:
    int countPoints(string s) {

        bool count[10][3] = {};  
        for (int i = 0; i < s.size(); i += 2){
            int color = s[i] == 'R' ? 0 : (s[i] == 'G' ? 1 : 2) , index = s[i+1] - '0';
            count[index][color] = true;
        }
        
        int result = 0;
        for (int i = 0; i < 10; ++i)
            result += count[i][0] && count[i][1] && count[i][2];
        
        return result;
    }
};