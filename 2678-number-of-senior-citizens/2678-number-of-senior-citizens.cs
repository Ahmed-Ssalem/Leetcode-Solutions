public class Solution {
    public int CountSeniors(string[] details) {

        var res = 0;

        foreach (var info in details)
        {
            string ageString = info.Substring(11, 2); // Extract two characters starting at index 11
            int age = int.Parse(ageString);

            if (age > 60)
                res++;
        }
        return res;
    }
}