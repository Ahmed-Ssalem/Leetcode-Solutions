/* Write your T-SQL query statement below */

SELECT 
    E1.employee_id,
    E1.name,
    COUNT(E2.employee_id) AS reports_count,
    ROUND(AVG(E2.age * 1.0), 0) AS average_age
FROM Employees E1
JOIN Employees E2 ON E1.employee_id = E2.reports_to
GROUP BY E1.employee_id, E1.name
ORDER BY E1.employee_id