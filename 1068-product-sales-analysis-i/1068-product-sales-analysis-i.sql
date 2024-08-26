/* Write your T-SQL query statement below */
Select 
    product_name,
    year, 
    price
From  
    Sales s, Product p
where 
    p.product_id = s.product_id