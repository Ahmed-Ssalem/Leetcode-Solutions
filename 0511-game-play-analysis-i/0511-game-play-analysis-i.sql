/* Write your T-SQL query statement below */

select player_id, Min(event_date) as first_login
from Activity
group by player_id