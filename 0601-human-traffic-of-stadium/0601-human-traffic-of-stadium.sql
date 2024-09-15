/* Write your T-SQL query statement below */

WITH T AS(
    SELECT 
        *, 
        LEAD(peopleMoreThan100)   OVER (ORDER BY id) lead1,
        LEAD(peopleMoreThan100,2) OVER (ORDER BY id) lead2,
        LAG(peopleMoreThan100)    OVER (ORDER BY id) lag1,
        LAG(peopleMoreThan100,2)  OVER (ORDER BY id) lag2
    FROM
    (  
        SELECT 
            *,
            CASE
                WHEN people>= 100 THEN 1 
                ELSE 0 
            END AS peopleMoreThan100
        FROM stadium
    ) AS PeopleTable
)

SELECT 
    id, 
    visit_date,
    people 
FROM T
WHERE
    (PeopleMoreThan100 = 1 AND lead1 = 1 AND lead2 = 1) OR
    (PeopleMoreThan100 = 1 AND lead1 = 1 AND lag1 =1) OR
    (PeopleMoreThan100 = 1 AND lag1 = 1 AND lag2 = 1)

