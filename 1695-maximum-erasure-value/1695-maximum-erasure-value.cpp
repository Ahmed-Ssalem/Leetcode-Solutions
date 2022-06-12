class Solution {
public:
    int maximumUniqueSubarray(vector<int>& nums) {
        
        int score = -1, sum = 0, start = 0;
        vector <int> prefix;
        vector <int> unique (1e4 + 1, -1);
        
        for (int num : nums){
            sum += num;
            prefix.push_back(sum);
        }
        for (int i = 0; i < nums.size(); ++i){
            if (unique[nums[i]] != -1)
                start = max (start, unique[nums[i]] + 1);
            unique[nums[i]] = i;
            int left = (start == 0) ? 0 : prefix[start-1];
            score = max(score, prefix[i] - left);
        }
        return score;
    }
};