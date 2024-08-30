# Write your MySQL query statement below

SELECT 
    p.product_id,
    IFNULL( ROUND( SUM(units * price) / SUM(units), 2), 0) AS average_price
FROM Prices p
LEFT JOIN UnitsSold us
ON 
    p.product_id = us.product_id AND 
    purchase_date BETWEEN start_date AND end_date
GROUP BY product_id