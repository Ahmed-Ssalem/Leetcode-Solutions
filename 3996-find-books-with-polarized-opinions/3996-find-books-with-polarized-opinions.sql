# Write your MySQL query statement below

select 
    rs.book_id, 
    b.title,
    b.author,
    b.genre,
    b.pages,
    (Max(rs.session_rating) - Min(rs.session_rating)) as rating_spread,
    Round((Sum(case when rs.session_rating <= 2 or rs.session_rating >= 4 then 1 else 0 end) / Count(rs.session_rating)), 2) as polarization_score 
from books b 
join reading_sessions rs on b.book_id = rs.book_id
group by rs.book_id, b.title, b.author, b.genre, b.pages
having 
    Count(rs.session_rating) >= 5 And
    Min(rs.session_rating) <= 2 And
    Max(rs.session_rating) >= 4 And
    Sum(case when rs.session_rating <= 2 or rs.session_rating >= 4 then 1 else 0 end) / Count(rs.session_rating) >= 0.6
Order by polarization_score desc, title desc