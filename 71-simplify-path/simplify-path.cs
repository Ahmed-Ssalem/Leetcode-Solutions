public class Solution {
    public string SimplifyPath(string path) {
        
        var components = path.Split('/');
        var stack = new Stack<string>();

        foreach(var component in components)
        {
            if (String.IsNullOrEmpty(component) || component == ".")
                continue;
            else if (component == "..")
            {
                if (stack.Count > 0)
                    stack.Pop();
            }
            else
                stack.Push(component);
        }
        return "/" + string.Join("/", stack.Reverse().ToArray());
    }
}