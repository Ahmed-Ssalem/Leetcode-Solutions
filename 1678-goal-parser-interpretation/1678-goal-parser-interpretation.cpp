class Solution {
public:
    string interpret(string command) {
        string res = "";
        for (int i = 0; i < command.length(); ++i){
            if (command[i] == 'G')
                res += 'G';
            else if (command[i] == '(' && command[i+1] == ')')
                res += 'o';
            else if (command[i] == '(' && command[i+1] == 'a')
                res += "al";
            else 
                continue;
        }
        return res;
    }
};