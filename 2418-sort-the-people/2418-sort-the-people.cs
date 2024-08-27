public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        /*
        Dictionary<int, string> peopleHeights= new Dictionary<int,string>();

        for (int i = 0; i < names.Length; ++i)
            peopleHeights[heights[i]] = names[i];
        
        var orderedHeights = peopleHeights
                             .OrderByDescending(p => p.Key)
                             .Select(p => p.Value)
                             .ToArray();
        
        return orderedHeights;
        */
        Array.Sort(heights, names);
        var res = names.ToList<string>();
        res.Reverse();
        return res.ToArray();
    }
}