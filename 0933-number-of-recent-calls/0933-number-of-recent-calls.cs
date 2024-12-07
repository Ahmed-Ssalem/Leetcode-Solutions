public class RecentCounter {
    
    private Queue<int> _queue = new Queue<int>();

    public RecentCounter() 
    {
        _queue = new Queue<int>();

    }
    
    public int Ping(int t) 
    {
        _queue.Enqueue(t);

        while(_queue.Peek() < t - 3000)
            _queue.Dequeue();
        
        return _queue.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */