public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        
        int remainingFruits = 0;
        bool[] used = new bool[baskets.Length];

        for (int i = 0; i < fruits.Length; ++i)
        {
            bool placed = false;
            for (int j = 0; j < baskets.Length; ++j)
                if (!used[j] &&fruits[i] <= baskets[j])
                {
                    used[j] = true;
                    placed = true;
                    break;
                }
            
            if (!placed) 
                remainingFruits++;
            
        } 
        return remainingFruits;
    }
}