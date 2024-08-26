/* Write your T-SQL query statement below */
Select 
    p.product_name,
    s.year, 
    s.price
From  
    sales s
Inner Join
    Product p On p.product_id = s.product_id