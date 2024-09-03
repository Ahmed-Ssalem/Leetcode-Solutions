/* Write your T-SQL query statement below */

SELECT TOP 1 person_name
FROM (
        SELECT 
            *,
            SUM(weight) OVER (ORDER BY turn) AS total_weight
        FROM Queue
    ) AS weights
WHERE total_weight <= 1000
ORDER BY total_weight DESC
