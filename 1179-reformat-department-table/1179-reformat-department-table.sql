/* Write your T-SQL query statement below */

/* Write your T-SQL query statement below */

SELECT 
    id,
    SUM (CASE month WHEN 'Jan' THEN revenue ELSE NULL END) AS Jan_Revenue,
    SUM (CASE month WHEN 'Feb' THEN revenue ELSE NULL END) AS Feb_Revenue,
    SUM (CASE month WHEN 'Mar' THEN revenue ELSE NULL END) AS Mar_Revenue,
    SUM (CASE month WHEN 'Apr' THEN revenue ELSE NULL END) AS Apr_Revenue,    
    SUM (CASE month WHEN 'May' THEN revenue ELSE NULL END) AS May_Revenue,
    SUM (CASE month WHEN 'Jun' THEN revenue ELSE NULL END) AS Jun_Revenue,
    SUM (CASE month WHEN 'Jul' THEN revenue ELSE NULL END) AS Jul_Revenue,
    SUM (CASE month WHEN 'Aug' THEN revenue ELSE NULL END) AS Aug_Revenue,
    SUM (CASE month WHEN 'Sep' THEN revenue ELSE NULL END) AS Sep_Revenue,
    SUM (CASE month WHEN 'Oct' THEN revenue ELSE NULL END) AS Oct_Revenue,
    SUM (CASE month WHEN 'Nov' THEN revenue ELSE NULL END) AS Nov_Revenue,
    SUM (CASE month WHEN 'Dec' THEN revenue ELSE NULL END) AS Dec_Revenue
FROM Department
GROUP BY id



-- SELECT
--     id, 
--     Jan AS Jan_Revenue,
--     Feb AS Feb_Revenue,
--     Mar AS Mar_Revenue,
--     Apr AS Apr_Revenue,
--     May AS May_Revenue,
--     Jun AS Jun_Revenue,
--     Jul AS Jul_Revenue,
--     Aug AS Aug_Revenue,
--     Sep AS Sep_Revenue,
--     Oct AS Oct_Revenue,
--     Nov AS Nov_Revenue,
--     Dec AS Dec_Revenue
-- FROM Department
-- PIVOT
-- (
--     SUM (revenue)
--     FOR month
--     IN ([Jan],[Feb],[Mar],[Apr],[May],[Jun],[Jul],[Aug],[Sep],[Oct],[Nov],[Dec])
-- ) AS PivotTable