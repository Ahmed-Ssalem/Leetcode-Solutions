/* Write your T-SQL query statement below */

delete from Person
where id not in(
                select Min(id) 
                from Person
                group by email
                )