/* Write your T-SQL query statement below */

SELECT 
    ISNULL(
           (SELECT TOP 1 num 
            FROM MyNumbers
            GROUP BY num
            HAVING COUNT(num) = 1
            ORDER BY num desc), NULL) AS num