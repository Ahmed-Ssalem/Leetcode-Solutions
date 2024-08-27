/* with left join */

select c.name as Customers
from 
    Customers c 
left join 
    Orders o on c.id = o.customerId
where o.id is null

/* with subquery */

/*
select name as Customers
from Customers
where id not in (
                    select customerId
                    from Orders
                );
*/