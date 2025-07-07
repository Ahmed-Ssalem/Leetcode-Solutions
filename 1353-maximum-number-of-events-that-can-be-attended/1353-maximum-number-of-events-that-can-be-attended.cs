public class Solution {
    public int MaxEvents(int[][] events) {
        
        Array.Sort(events, (a, b) => a[0] - b[0]);

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        int i = 0; 
        int day = 1; 
        int n = events.Length; 
        int res = 0;

        while (i < n || pq.Count > 0)
        {
            if (i < n && pq.Count == 0)
                day = events[i][0];
            
            while (i < n && events[i][0] <= day)
            {
                pq.Enqueue(events[i][1], events[i][1]);
                i++;
            }

            if (pq.Count > 0)
            {
                pq.Dequeue();
                res++;
                day++;
            }

            while (pq.Count > 0 && pq.Peek() < day)
                pq.Dequeue();
        }

        return res;
    }
}