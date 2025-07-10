# Write your MySQL query statement below
select 
    user_id,
    ROUND(AVG(case when activity_type = 'free_trial' then activity_duration END), 2) AS trial_avg_duration,
    ROUND(AVG(case when activity_type = 'paid' then activity_duration END), 2) AS paid_avg_duration
from UserActivity
GROUP BY user_id
having paid_avg_duration is not null and trial_avg_duration is not null
