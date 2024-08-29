/* Write your T-SQL query statement below */

SELECT 
    query_name,
    ROUND( AVG(rating * 1.0 / position), 2) AS quality,
    ROUND( SUM( IIF(rating < 3, 100.0, 0)) / COUNT(rating), 2) AS poor_query_percentage
FROM Queries
WHERE query_name IS NOT NULL
GROUP BY query_name
