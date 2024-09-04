/* Write your T-SQL query statement below */

WITH DateRanges AS (
    SELECT 
        DISTINCT visited_on AS start_date, 
        DATEADD(DAY, 6, visited_on) AS end_date
    FROM Customer
)

SELECT 
    t.end_date AS visited_on,
    SUM(a.amount) AS amount,
    ROUND(SUM(CAST(a.amount AS DECIMAL(10, 2))) / 7.0, 2) AS average_amount
FROM DateRanges t
JOIN Customer a
ON 
    a.visited_on BETWEEN t.start_date AND t.end_date
    AND end_date IN (SELECT DISTINCT visited_on FROM Customer)
GROUP BY t.end_date
