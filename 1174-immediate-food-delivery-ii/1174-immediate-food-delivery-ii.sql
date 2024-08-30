/* Write your T-SQL query statement below */

SELECT 
    ROUND(SUM(IIF(order_date = customer_pref_delivery_date, 1.0, 0)) * 100.0 / COUNT(order_date), 2) AS immediate_percentage
FROM (
        SELECT 
            *, 
            ROW_NUMBER() OVER (PARTITION BY customer_id ORDER BY order_date) AS RowNum
        FROM Delivery
    ) AS NEWTABLE
WHERE RowNum = 1


