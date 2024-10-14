public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        
        foreach (var img in image)
        {
            int i = 0, j = image.Length - 1;
            
            while(j >= i)
            {
                var temp = img[i] == 0 ? 1 : 0;
                img[i] = img[j] == 0 ? 1 : 0;
                img[j] = temp;

                ++i;
                --j;
            }
        }

        return image;
    }
}