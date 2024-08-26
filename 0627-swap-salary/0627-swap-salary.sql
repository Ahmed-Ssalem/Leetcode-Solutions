/* Write your T-SQL query statement below */

Update Salary
Set sex = Case
            When sex = 'f' then 'm'
            When sex = 'm' then 'f'
          End;