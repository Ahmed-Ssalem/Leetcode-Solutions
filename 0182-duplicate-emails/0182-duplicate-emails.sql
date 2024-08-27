/* Write your T-SQL query statement below */
/*
select email
from Person
where
*/

select email as Email
from Person
group by email
having count(email) > 1