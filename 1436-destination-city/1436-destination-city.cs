public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        
        var check = new Dictionary<string, string>();

        foreach (var path in paths){
            
            check[path[0]] = "out";

            if (!check.ContainsKey(path[1]))
                check[path[1]] = "in";
        }

        foreach (var item in check.Keys)
            if (check[item] == "in") return item;

        return "";
    }
}