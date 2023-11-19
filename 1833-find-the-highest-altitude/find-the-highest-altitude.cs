public class Solution {
    public int LargestAltitude(int[] gain) {
        int currentAltitude = 0, maxAltitude = 0;
        foreach (int i in gain){
            currentAltitude += i;
            if (currentAltitude > maxAltitude)
            maxAltitude = currentAltitude;
        }
        return maxAltitude;

    }
}