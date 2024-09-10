/* Write your T-SQL query statement below */


SELECT 
    user_id AS buyer_id,
    join_date,
    COUNT(order_id) AS orders_in_2019
FROM Users U
LEFT JOIN Orders O 
ON 
    U.user_id = O.buyer_id AND
    YEAR(order_date) = '2019'
GROUP BY 
    user_id,
    join_date


