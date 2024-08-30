/* Write your T-SQL query statement below */

SELECT 
    a1.machine_id,
    ROUND( AVG( a2.timestamp * 1.0 - a1.timestamp), 3) AS processing_time
FROM Activity a1
JOIN Activity a2 
ON 
    a1.machine_id = a2.machine_id AND 
    a1.process_id = a2.process_id AND 
    a2.activity_type = 'end' AND
    a1.activity_type = 'start'
GROUP BY a1.machine_id