/* Write your T-SQL query statement below */

SELECT MAX(salary) AS SecondHighestSalary
FROM (
        SELECT 
            *,
            DENSE_RANK() OVER(ORDER BY salary DESC) AS DR
        FROM Employee
    ) AS RankedEmployee
WHERE DR = 2

/*

SELECT MAX(salary) AS SecondHighestSalary 
FROM Employee 
WHERE salary < (SELECT MAX(salary) FROM employee);

*/