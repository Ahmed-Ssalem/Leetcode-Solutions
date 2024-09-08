public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        var cnt = 0;

        for (int i = 0; i < flowerbed.Length; ++i){
            
            if (flowerbed[i] == 0){
                
                bool emptyLeftPlot = (i == 0) || (flowerbed[i-1] == 0);
                bool emptyRightPlot = (i == flowerbed.Length - 1) || (flowerbed[i+1] == 0);
            
                if (emptyLeftPlot && emptyRightPlot){
                    cnt++;
                    flowerbed[i] = 1; 
                }
            }
        }

        return cnt >= n;   
    }
}