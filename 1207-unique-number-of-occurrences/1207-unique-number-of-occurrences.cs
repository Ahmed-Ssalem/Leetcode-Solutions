public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        
        var occurrence = new Dictionary<int, int>();
        
        foreach (var num in arr)
        {
            if (!occurrence.ContainsKey(num))   
                occurrence[num] = 1;
            
            occurrence[num]++;
        }

        var uniqueOccurrence = new HashSet<int>();

        foreach (var count in occurrence.Values)
        {
            if (uniqueOccurrence.Contains(count))
                return false;
            
            uniqueOccurrence.Add(count);
        }

        return true;
    }
}