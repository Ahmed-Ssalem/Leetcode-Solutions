public class FindSumPairs {

    private int[] _nums1;
    private int[] _nums2;
    private Dictionary<int, int> _seconedArr;
    private int _count;

    public FindSumPairs(int[] nums1, int[] nums2) {
        _nums1 = nums1;
        _nums2 = nums2;
        _seconedArr = new Dictionary<int, int>();
        _count = 0;
        foreach (int num in _nums2)
        {
            if (_seconedArr.ContainsKey(num))
                _seconedArr[num]++;
            else
                _seconedArr[num] = 1;
        }
    }
    
    public void Add(int index, int val) {
        int oldVal = _nums2[index];

        if (_seconedArr.ContainsKey(oldVal))
        {
            _seconedArr[oldVal]--;
            if (_seconedArr[oldVal] == 0)
                _seconedArr.Remove(oldVal);
        }

        _nums2[index] += val;
        int newVal = _nums2[index];

        if (_seconedArr.ContainsKey(newVal))
            _seconedArr[newVal]++;
        else
            _seconedArr[newVal] = 1;
    }
    
    public int Count(int tot) {
        _count = 0;
        foreach (int num in _nums1)
        {
            int res = tot - num;
            if (_seconedArr.ContainsKey(res))
                _count += _seconedArr[res];  
        }
        return _count;
    }
}

/**
 * Your FindSumPairs object will be instantiated and called as such:
 * FindSumPairs obj = new FindSumPairs(nums1, nums2);
 * obj.Add(index,val);
 * int param_2 = obj.Count(tot);
 */