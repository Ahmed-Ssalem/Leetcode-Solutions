public class RandomizedSet {

    List<int> elements;
    Dictionary<int,int> indicies;
    Random rand;

    public RandomizedSet() {
        elements = new List<int>();
        indicies = new Dictionary<int, int>();
        rand = new Random();
    }
    
    public bool Insert(int val) {
        
        if (indicies.ContainsKey(val))
            return false;
        
        indicies[val] = elements.Count;
        elements.Add(val);
        return true;

    }
    
    public bool Remove(int val) {
        
        if (!indicies.ContainsKey(val))
            return false;
        
        var lastElement = elements[elements.Count-1];
        var idxToRemove = indicies[val];

        elements[idxToRemove] = lastElement;
        indicies[lastElement] = idxToRemove;

        elements.RemoveAt(elements.Count-1);
        indicies.Remove(val);

        return true;

    }
    
    public int GetRandom() {
        int randomIndex = rand.Next(elements.Count);
        return elements[randomIndex];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */