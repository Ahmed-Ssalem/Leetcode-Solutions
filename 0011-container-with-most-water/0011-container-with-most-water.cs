public class Solution {
    public int MaxArea(int[] height) {
        
        int left = 0, right = height.Length - 1, area = 0, calcArea = 0;
        
        while (right > left)
        {
            calcArea = (right - left) * Math.Min(height[right], height[left]);
            
            if (calcArea > area)
                area = calcArea;
            
            if (height[left] > height[right])
                right--;
            else if (height[left] < height[right])
                left++;
            else
            {
                right--;
                left++;
            }
        }
        return area;
    }
}