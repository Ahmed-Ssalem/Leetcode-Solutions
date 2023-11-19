public class Solution {
    public int LargestAltitude(int[] gain) {
        int [] arr = new int[gain.Length + 1 ];
        int sum = 0, res = 0;
        arr[0] = 0;
        for (int i = 0; i < gain.Length; ++i){
            sum += gain[i];
            arr[i + 1] = sum;
        }
        res = arr.Max();
        return res;

    }
}