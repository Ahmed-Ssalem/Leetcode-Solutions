public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
        
        int res = 0;
        Array.Sort(players);
        Array.Sort(trainers);

        int j = 0;
        for (int i = 0; i < players.Length; i++)
            while (j < trainers.Length)
            {     
                j++;         
                if (players[i] <= trainers[j-1])
                {
                    res++;
                    break;
                }
            }
            
        return res;
    }
}