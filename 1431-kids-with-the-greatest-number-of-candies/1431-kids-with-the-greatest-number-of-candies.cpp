class Solution {
public:
    vector<bool> kidsWithCandies(vector<int>& candies, int extraCandies) {
        
        int max = -1;
        vector <bool> result;
        
        for (int x : candies)
            if (max < x)
                max = x;
        
        for (int x : candies){
            if (x + extraCandies >= max)
                result.push_back(true);
            else
                result.push_back(false);
        }
        
        return result;
    }
};