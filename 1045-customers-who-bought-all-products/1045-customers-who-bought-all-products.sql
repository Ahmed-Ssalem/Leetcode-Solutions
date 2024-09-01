/* Write your T-SQL query statement below */

SELECT customer_id
FROM (
        SELECT 
            customer_id,
            COUNT(DISTINCT product_key) AS ProductCount
        FROM Customer
        GROUP BY customer_id
        HAVING COUNT(DISTINCT product_key) = (SELECT COUNT(*) FROM Product)
    ) AS ProductCounts