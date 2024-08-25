public class Solution {
    public int[] Decode(int[] encoded, int first) {

        var len = encoded.Length + 1;
        int[] decoded = new int[len];
        decoded[0] = first;
        
        for (int i = 0; i < len - 1; ++i)
            decoded[i+1] = encoded[i] ^ decoded[i]; 
        
        return decoded; 
        
    }
}