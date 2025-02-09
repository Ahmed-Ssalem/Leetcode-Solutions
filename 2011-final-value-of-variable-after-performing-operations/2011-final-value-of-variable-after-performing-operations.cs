public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        
        int x = 0;
        foreach (var operation in operations)
        {
            if (operation == "++X" || operation == "X++")
                ++x;
            else
                --x;
        }
        return x;
    }
}