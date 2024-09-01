/* Write your T-SQL query statement below */

SELECT 
    NT.product_id, 
    year AS first_year, 
    quantity, 
    price
FROM (
    SELECT 
        *,
        ROW_NUMBER() OVER(PARTITION BY product_id ORDER BY year) AS RN
    FROM Sales) AS NT
JOIN Product P ON NT.product_id = P.product_id
WHERE RN = 1