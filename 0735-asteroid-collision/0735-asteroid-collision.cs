public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        
        var asteroidsStack = new Stack<int>();

        foreach (var asteroid in asteroids)
        {
            if (asteroid > 0)
                asteroidsStack.Push(asteroid);
            else{
                while (asteroidsStack.Count > 0 && asteroidsStack.Peek() > 0 && asteroidsStack.Peek() < Math.Abs(asteroid))
                    asteroidsStack.Pop();
                if (asteroidsStack.Count == 0 || asteroidsStack.Peek() < 0) 
                    asteroidsStack.Push(asteroid);
                else if (asteroidsStack.Peek() == Math.Abs(asteroid)) 
                    asteroidsStack.Pop();  
            }  
        }
        return asteroidsStack.Reverse().ToArray();
    }
}