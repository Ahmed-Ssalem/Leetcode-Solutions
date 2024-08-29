/* Write your T-SQL query statement below */

SELECT w1.id
FROM Weather w1
JOIN Weather w2
ON 
    W1.recordDate = DATEADD(day, 1, W2.recordDate) AND 
    w1.temperature > w2.temperature
