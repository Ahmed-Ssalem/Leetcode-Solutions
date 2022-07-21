/* Write your T-SQL query statement below */






select customer_id, count(visit_id) as count_no_trans
from visits 
where visit_id not in (select t.visit_id 
                       from visits v, transactions t 
                       where v.visit_id = t.visit_id)
group by customer_id







