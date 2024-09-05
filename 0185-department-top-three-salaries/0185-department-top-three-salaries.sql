/* Write your T-SQL query statement below */
WITH Top_Department_Salary AS(
    SELECT 
        E.id,
        E.name emp_name,
        salary,
        D.name AS dep_name,
        DENSE_RANK() OVER(PARTITION BY departmentId ORDER BY salary DESC) AS salary_rank
    FROM Employee E
    JOIN Department D ON E.departmentId = D.id
)

SELECT 
    dep_name AS Department,
    emp_name AS Employee,
    Salary
FROM Top_Department_Salary
WHERE salary_rank = 1 OR salary_rank = 2 OR salary_rank = 3