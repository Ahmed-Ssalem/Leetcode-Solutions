public class Solution {
    public int FinalPositionOfSnake(int n, IList<string> commands) {

        int row = 0, col = 0;
        
        foreach(var command in commands){
            if (command == "RIGHT" && col < n - 1)
                col++;
            else if (command == "DOWN" && row < n - 1)
                row++;
            else if (command == "UP" && row > 0)
                row--;
            else if (command == "LEFT" && col > 0)
                col--;    
        }
        return (row * n) + col;
        
    }
}