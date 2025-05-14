# Write your MySQL query statement below
select * 
from products
where description like '% SN____-____' or description like '% SN____-____ %'
order by product_id asc;