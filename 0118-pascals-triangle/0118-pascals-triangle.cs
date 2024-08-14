public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        // Initialize the result list of lists
        IList<IList<int>> triangle = new List<IList<int>>();

        // Edge case: if no rows are requested, return an empty list
        if (numRows == 0)
        {
            return triangle;
        }

        // Add the first row (always [1])
        triangle.Add(new List<int> { 1 });

        // Generate each row
        for (int i = 1; i < numRows; i++)
        {
            List<int> row = new List<int>();
            IList<int> previousRow = triangle[i - 1];

            // First element of each row is always 1
            row.Add(1);

            // Each element (except the first and last) is the sum of the two elements above it
            for (int j = 1; j < i; j++)
            {
                row.Add(previousRow[j - 1] + previousRow[j]);
            }

            // Last element of each row is always 1
            row.Add(1);

            // Add the row to the triangle
            triangle.Add(row);
        }

        return triangle;
    }
}
