public class Solution {
    public long MaxEnergyBoost(int[] energyDrinkA, int[] energyDrinkB) {
        int n = energyDrinkA.Length;

        // Initialize the dp arrays
        long[] dpA = new long[n];
        long[] dpB = new long[n];

        // Initial states
        dpA[0] = energyDrinkA[0];
        dpB[0] = energyDrinkB[0];

        // Fill dp arrays
        for (int i = 1; i < n; i++) {
            // Continuation with A or switch from B
            dpA[i] = Math.Max(dpA[i-1] + energyDrinkA[i], dpB[i-1]);
            // Continuation with B or switch from A
            dpB[i] = Math.Max(dpB[i-1] + energyDrinkB[i], dpA[i-1]);
        }

        // Final result
        return Math.Max(dpA[n-1], dpB[n-1]);
    }
}