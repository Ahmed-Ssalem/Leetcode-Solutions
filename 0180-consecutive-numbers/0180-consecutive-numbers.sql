/* Write your T-SQL query statement below */

/*
SELECT DISTINCT num AS ConsecutiveNums
FROM (
        SELECT 
            LAG(id) OVER (ORDER BY id) AS prev_id,
            id,
            LEAD(id) OVER (ORDER BY id) AS next_id,
            LAG(num) OVER(ORDER BY id) AS priv_num,
            num,
            LEAD(num) OVER(ORDER BY id) AS next_num
        FROM Logs
    ) AS T
WHERE  
    num = priv_num AND 
    num = next_num AND 
    next_id - id = 1 AND 
    id - prev_id = 1;
*/

SELECT DISTINCT l1.num AS ConsecutiveNums
FROM Logs l1
JOIN Logs l2 ON l1.id = l2.id - 1
JOIN Logs l3 ON l1.id = l3.id - 2
WHERE l1.num = l2.num AND l2.num = l3.num;
