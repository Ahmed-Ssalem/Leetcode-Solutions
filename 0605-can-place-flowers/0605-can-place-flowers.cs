public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        var cnt = 0;

        for (int i = 0; i < flowerbed.Length; ++i)
            if (flowerbed[i] == 0 && i != 0 && i != flowerbed.Length - 1 && flowerbed[i+1] == 0 && flowerbed[i-1] == 0){
                cnt++;
                flowerbed[i] = 1; 
            }
            else if (flowerbed[i] == 0 && i != 0 &&  i == flowerbed.Length - 1 && flowerbed[i-1] == 0){
                cnt++;
                flowerbed[i] = 1; 
            }
            else if (flowerbed[i] == 0 && i == 0 && i != flowerbed.Length - 1 && flowerbed[i+1] == 0){
                cnt++;
                flowerbed[i] = 1; 
            }
            else if (flowerbed[i] == 0 && flowerbed.Length == 1){
                cnt++;
                flowerbed[i] = 1; 
            }

        return cnt >= n ? true : false;
                
            
        
    }
}