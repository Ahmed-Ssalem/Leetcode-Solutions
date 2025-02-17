class Solution {
public:
    int calPoints(vector<string>& operations) {
        
        int res = 0;
        stack<int> scores;

        for (string operation : operations)
        {
            if (operation == "C")
            {
                scores.pop();
            }
            else if (operation == "D")
            {
                scores.push(scores.top() * 2);
            }
            else if (operation == "+")
            {
                int top1 = scores.top();
                scores.pop();
                int top2 = scores.top();
                scores.push(top1);
                scores.push(top1 + top2);
            }
            else
                scores.push(stoi(operation));            
        }

        while (!scores.empty()){
            res += scores.top();
            scores.pop();
        }

        return res;
    }
};