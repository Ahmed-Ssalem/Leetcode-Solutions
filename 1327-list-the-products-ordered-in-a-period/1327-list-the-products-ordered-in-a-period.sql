/* Write your T-SQL query statement below */

SELECT 
    product_name,
    SUM(unit) AS unit
FROM Orders O
JOIN Products P ON O.product_id = P.product_id
WHERE year(order_date) = 2020 AND month(order_date) = 2
GROUP BY P.product_id, product_name
HAVING SUM(unit) >= 100 