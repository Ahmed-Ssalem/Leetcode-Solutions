/* Write your T-SQL query statement below */

WITH tiv_2016 AS(
    SELECT
        pid, 
        tiv_2015, 
        tiv_2016,
        COUNT(pid) OVER(PARTITION BY tiv_2015) AS tiv2015_cnt,
        COUNT(pid) OVER(PARTITION BY lat, lon) AS latlon_cnt
    FROM Insurance
)

SELECT ROUND(SUM(tiv_2016), 2) AS tiv_2016
FROM tiv_2016
WHERE 
    tiv2015_cnt > 1 AND
    latlon_cnt = 1

/*
SELECT ROUND(SUM(tiv_2016), 2) AS tiv_2016
FROM Insurance
WHERE 
    tiv_2015 IN (
        SELECT tiv_2015
        FROM Insurance
        GROUP BY tiv_2015
        HAVING COUNT(tiv_2015) > 1
    ) AND
    CONCAT(lat, lon) IN (
        SELECT DISTINCT CONCAT(lat, lon)
        FROM Insurance
        GROUP BY CONCAT(lat, lon)
        HAVING COUNT(CONCAT(lat, lon)) = 1
    )
*/