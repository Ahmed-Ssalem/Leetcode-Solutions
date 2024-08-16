public class Solution {
    public bool LemonadeChange(int[] bills) {
        
        int five = 0, ten = 0;

        foreach (var bill in bills){

            if (bill == 5) 
                five++;
            else if (bill == 10){
                if (five > 0){
                    five--;
                    ten++;
                }
                else{
                    return false;
                    break;
                }
            } 
            else{
                if (ten > 0 && five > 0){
                    ten--;
                    five--;
                }
                else{
                    return false;
                    break;
                }
            }
        }

        return true; 
    }
}