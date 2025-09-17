public class FoodRatings {

    Dictionary<string, (string cuisine, int rating)> foodsInfo;
    Dictionary<string, SortedSet<(int rating, string food)>> cuisineFoods;

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) 
    {
        foodsInfo = new Dictionary<string, (string, int)>();
        cuisineFoods = new Dictionary<string, SortedSet<(int, string)>>();

        for (int i = 0; i < foods.Length; ++i)
        {
            string food = foods[i];
            string cuisine = cuisines[i];
            int rating = ratings[i];

            foodsInfo[food] = (cuisine, rating);

            if (!cuisineFoods.ContainsKey(cuisine))
            {
                cuisineFoods[cuisine] = new SortedSet<(int, string)>(
                    Comparer<(int, string)>.Create((a, b) => {
                        int cmp = b.Item1.CompareTo(a.Item1);
                        if (cmp == 0)
                            return a.Item2.CompareTo(b.Item2);
                        return cmp;
                    })
                );

            }
            cuisineFoods[cuisine].Add((rating, food));
        }
    }
  
    public void ChangeRating(string food, int newRating) 
    {
        var (cuisine, oldRating) = foodsInfo[food];
        cuisineFoods[cuisine].Remove((oldRating, food));
        cuisineFoods[cuisine].Add((newRating, food));
        foodsInfo[food] = (cuisine, newRating);
    }
    
    
    public string HighestRated(string cuisine) 
    {
        return cuisineFoods[cuisine].Min.food;
    }
}

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */