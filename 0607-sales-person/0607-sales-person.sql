/* Write your T-SQL query statement below */


SELECT s.name
FROM SalesPerson s
LEFT JOIN Orders o ON s.sales_id = o.sales_id
LEFT JOIN Company c ON o.com_id = c.com_id AND c.name = 'RED'
GROUP BY s.name
HAVING COUNT(c.com_id) = 0;

