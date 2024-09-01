

SELECT 
    ROUND(
        COUNT(DISTINCT A2.player_id) * 1.0 / 
        (SELECT COUNT(DISTINCT player_id) FROM Activity) -- get the total players count
    , 2) AS fraction
FROM (
    SELECT 
        player_id, 
        MIN(event_date) AS event_date  -- Return * of users that logged in first day
    FROM Activity
    GROUP BY  player_id
) A1
JOIN Activity A2 -- JOIN to Return * of users that logged in the next day after first log
ON 
    A1.player_id = A2.player_id AND 
    DATEDIFF(DAY,A1.event_date, A2.event_date) = 1
