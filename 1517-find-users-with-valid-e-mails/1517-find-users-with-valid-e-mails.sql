/* Write your T-SQL query statement below */
/*
SELECT *
FROM USERS
WHERE
    RIGHT(MAIL,13) = '@leetcode.com' AND 
    LEFT(MAIL,1) LIKE '[a-zA-Z]%' AND
    LEFT(MAIL, LEN(MAIL) - 13) NOT LIKE '%[^a-zA-Z0-9_.-]%';
*/


SELECT *
FROM Users 
WHERE 
    mail LIKE '[a-zA-Z]%@leetcode.com' AND 
    mail NOT LIKE '%[^a-zA-Z0-9_.-]%@leetcode.com'
