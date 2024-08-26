/* Write your T-SQL query statement below */

Select user_id, Max(time_stamp) As last_stamp
From Logins
Where Year(time_stamp) = 2020
Group By user_id
