public class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {
        
        int mCount = 0, pCount = 0, gCount = 0;
        int lastIndxM = -1, lastIndxP = -1, lastIndxG = -1;

        for (int i = 0; i < garbage.Length; ++i){
            foreach (int ch in garbage[i]){
                if (ch.Equals('M')){
                    mCount++;
                    lastIndxM = i;
                }else if (ch.Equals('P')){
                    pCount++;
                    lastIndxP = i;
                }else{
                    gCount++;
                    lastIndxG = i;
                }
            }
        }

        for (int i = 0; i < garbage.Length; ++i){
            if (i < lastIndxM && lastIndxM > 0)
                mCount += travel[i];
           
            if (i < lastIndxP && lastIndxP > 0)
                pCount += travel[i];
            
            if (i < lastIndxG && lastIndxG > 0)
                gCount += travel[i];
        }

        return mCount + pCount + gCount;

    }
}