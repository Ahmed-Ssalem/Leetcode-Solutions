/* Write your T-SQL query statement below */
select 
    store.product_id,
    store.store,
    store.price
from(
    select product_id, 'store1' as store, store1 as price from Products
    union all
    select product_id, 'store2' as store, store2 as price from Products
    union all
    select product_id, 'store3' as store, store3 as price from Products
) as store
where store.price is not null