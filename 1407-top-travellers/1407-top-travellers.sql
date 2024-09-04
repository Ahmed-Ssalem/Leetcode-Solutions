/* Write your T-SQL query statement below */

SELECT 
    name,
    ISNULL(SUM(distance), 0) AS travelled_distance
FROM Users U
LEFT JOIN Rides R ON U.id = R.user_id
GROUP BY name
ORDER BY  SUM(distance) DESC, name ASC