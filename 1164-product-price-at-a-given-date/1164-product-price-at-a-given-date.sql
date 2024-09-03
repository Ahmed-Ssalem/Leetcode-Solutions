/* Write your T-SQL query statement below */

SELECT 
    product_id,
    FIRST_VALUE(new_price) OVER (PARTITION BY product_id ORDER BY change_date DESC) AS price
FROM Products
WHERE change_date <= '2019-08-16'
UNION
SELECT
    product_id,
    10 AS price
FROM Products
GROUP BY product_id
HAVING MIN(change_date) > '2019-08-16'