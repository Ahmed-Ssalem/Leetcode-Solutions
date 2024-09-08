/* Write your T-SQL query statement below */


SELECT
    D.name AS Department,
    E.name AS Employee,
    salary
FROM (
        SELECT 
            *,
            DENSE_RANK() OVER(PARTITION BY departmentId ORDER BY salary DESC) salary_rank
        FROM Employee
) AS E
JOIN Department D ON E.departmentId = D.id
WHERE salary_rank = 1
