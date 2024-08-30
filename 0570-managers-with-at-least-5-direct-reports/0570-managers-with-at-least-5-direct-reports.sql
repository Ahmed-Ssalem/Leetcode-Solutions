/* Write your T-SQL query statement below */

SELECT E1.name
FROM Employee E1
JOIN Employee E2 ON E1.id = E2.managerId
GROUP BY E1.name
HAVING COUNT(E1.id) >=5