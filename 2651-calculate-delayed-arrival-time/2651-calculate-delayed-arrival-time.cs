public class Solution {
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime) {
        return arrivalTime + delayedTime >= 24 ? (arrivalTime + delayedTime) - 24 : arrivalTime + delayedTime;
    }
}