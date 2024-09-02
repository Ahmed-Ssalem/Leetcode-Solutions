/* Write your T-SQL query statement below */

SELECT *
FROM (
        -- Subquery for top user
        SELECT TOP 1 name AS results
        FROM Users U
        JOIN MovieRating MR ON U.user_id = MR.user_id
        GROUP BY name
        ORDER BY COUNT(MR.user_id) DESC, name

        UNION ALL

        -- Subquery for top movie
        SELECT TOP 1 title AS results
        FROM Movies M
        JOIN MovieRating MR ON M.movie_id = MR.movie_id
        WHERE MONTH(created_at) = 02 AND YEAR(created_at) = 2020 
        GROUP BY title
        ORDER BY AVG(CAST(rating AS FLOAT)) DESC, title
) T;

/*

WITH top_user AS(

        SELECT TOP 1 name AS results
        FROM Users U
        JOIN MovieRating MR ON U.user_id = MR.user_id
        GROUP BY name
        ORDER BY COUNT(MR.user_id) DESC, name
    ), 
    top_movie AS(

        SELECT TOP 1 title AS results
        FROM Movies M
        JOIN MovieRating MR ON M.movie_id = MR.movie_id
        WHERE MONTH(created_at) = 02 AND YEAR(created_at) = 2020 
        GROUP BY title
        ORDER BY AVG(CAST(rating AS FLOAT)) DESC, title
)

SELECT * FROM top_user
UNION ALL
SELECT * FROM top_movie
*/