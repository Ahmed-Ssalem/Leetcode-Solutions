/* Write your T-SQL query statement below */

SELECT 
    *,
    CASE
        WHEN SUM(x + y) > z AND SUM(x + z) > y AND SUM(y + z) > x THEN 'Yes' 
        ELSE 'No'
    END AS triangle
FROM Triangle
GROUP BY x, y, z