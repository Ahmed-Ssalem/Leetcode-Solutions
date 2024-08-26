/* Write your T-SQL query statement below */

select 
    distinct(x.author_id) as id
from 
    Views x
join 
    Views y on y.viewer_id = x.author_id