class Solution {
public:
    int thirdMax(vector<int>& nums) {
        set<int, greater<int>> s;
        for(int i = 0; i < nums.size(); ++i){
            s.insert(nums[i]);
        }
        if (s.size() < 3)
            return *s.begin();
        else{
            auto itr = s.begin();
            s.erase(itr);
            itr = s.begin();
            s.erase(itr);
            return *s.begin();
        }
        return 0;
    }
};