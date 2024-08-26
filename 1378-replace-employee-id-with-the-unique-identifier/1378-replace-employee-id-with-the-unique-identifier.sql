/* Write your T-SQL query statement below */

Select
    unique_id, name
From    
    Employees E
Left Join
    EmployeeUNI EUNI On E.id = EUNI.id
