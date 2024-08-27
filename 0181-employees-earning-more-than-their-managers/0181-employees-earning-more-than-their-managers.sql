/* Write your T-SQL query statement below */

select x.name as Employee
from Employee x, Employee y
where y.id = x.managerId and x.salary > y.salary
