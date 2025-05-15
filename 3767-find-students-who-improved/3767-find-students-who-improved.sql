# Write your MySQL query statement below

with cte As(
select distinct
    student_id, 
    subject, 
    FIRST_VALUE(score) OVER (
        PARTITION BY student_id, subject
        ORDER BY exam_date asc
    ) AS first_score,
    FIRST_VALUE(score) OVER (
        PARTITION BY student_id, subject
        ORDER BY exam_date desc
    ) AS latest_score
from scores)

select * 
from cte 
group by student_id, subject 
having first_score < latest_score;

-- select s1.student_id, s1.subject, s1.first_score, s2.latest_score 
-- from
-- (select distinct
--     student_id, 
--     subject, 
--     FIRST_VALUE(score) OVER (
--         PARTITION BY student_id, subject
--         ORDER BY exam_date asc
--     ) AS first_score,
--     FIRST_VALUE(score) OVER (
--         PARTITION BY student_id, subject
--         ORDER BY exam_date desc
--     ) AS latest_score
-- from scores) as s1
-- join 
-- (select distinct
--     student_id, 
--     subject, 
--     FIRST_VALUE(score) OVER (
--         PARTITION BY student_id, subject
--         ORDER BY exam_date desc
--     ) AS latest_score
-- from scores) as s2
-- on s1.student_id = s2.student_id and s1.subject = s2.subject and s2.latest_score > s1.first_score
