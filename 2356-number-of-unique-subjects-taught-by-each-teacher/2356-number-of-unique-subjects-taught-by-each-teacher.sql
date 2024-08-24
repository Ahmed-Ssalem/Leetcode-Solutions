/* Write your T-SQL query statement below */
select teacher_id, Count(distinct subject_id) as cnt
from Teacher
group by teacher_id
