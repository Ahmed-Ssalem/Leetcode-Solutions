/* Write your T-SQL query statement below */

SELECT 
    request_at AS Day,
    ROUND( 
            SUM(CASE WHEN status <> 'completed' THEN 1 ELSE 0 END) * 1.0 / COUNT(*), 
            2
        )  AS 'Cancellation Rate'
FROM Trips t
JOIN Users client 
ON 
    t.client_id = client.users_id AND 
    client.banned = 'No' 
JOIN Users driver 
ON 
    t.driver_id = driver.users_id AND 
    driver.banned = 'No' 
WHERE request_at BETWEEN '2013-10-01' AND '2013-10-03 '
GROUP BY request_at
