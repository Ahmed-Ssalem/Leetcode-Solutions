/* Write your T-SQL query statement below */
Select 
    sell_date,
    Count(product) As num_sold,
    STRING_AGG(product,',') WITHIN GROUP (ORDER BY product) as products
From (Select Distinct sell_date, product
      From Activities) Act
Group By sell_date
