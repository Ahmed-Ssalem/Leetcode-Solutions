public class Solution {
    public string DecodeString(string s) {
        
        var stack = new Stack<string>();
        var res = "";

        foreach (char c in s)
        {
            if (c != ']')
                stack.Push(c.ToString());
            else
            {
                var str = "";
                var stackVal = stack.Pop().ToString();
                while (stackVal != "[")
                {
                    str = stackVal + str;
                    stackVal = stack.Pop().ToString();
                }

                var stackDigit = "";
                while (stack.Count > 0 && char.IsDigit(stack.Peek().ToCharArray()[0]))
                    stackDigit = stack.Pop() + stackDigit;
                
                if (int.TryParse(stackDigit, out var multiplier))
                {
                    str = String.Concat(Enumerable.Repeat(str, multiplier));
                    stack.Push(str);
                }
            }
        }

        while (stack.Count > 0)
            res = stack.Pop().ToString() + res;

        return res;        
    }
}