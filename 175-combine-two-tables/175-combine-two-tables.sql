/* Write your T-SQL query statement below */
select firstName, lastName, city, state
from Person p left join Address a
on p.personId = a.personId