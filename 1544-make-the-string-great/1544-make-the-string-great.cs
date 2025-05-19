public class Solution {
    public string MakeGood(string s) {
        
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (stack.Count != 0)
            {
                if (Math.Abs(c - stack.Peek()) == 32){
                    stack.Pop();
                    continue;
                }
            }
            stack.Push(c);
        }
        
        char[] res = stack.ToArray();
        Array.Reverse(res);
        return new string(res);
    }
}