CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN

    DECLARE @salary INT;

    SELECT @salary = salary
    FROM (
        SELECT
            salary,
            DENSE_RANK() OVER(ORDER BY salary) AS rank
        FROM Employee
    ) AS Salary_Rank
    WHERE rank = @N;

    RETURN @salary;

END;












