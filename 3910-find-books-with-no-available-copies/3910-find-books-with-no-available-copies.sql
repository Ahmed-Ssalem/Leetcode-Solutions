# Write your MySQL query statement below
SELECT 
    LB.book_id ,
    LB.title,
    LB.author,
    LB.genre,
    LB.publication_year,
    LB.total_copies AS current_borrowers
FROM library_books LB
JOIN (
    SELECT 
        book_id,
        COUNT(*) AS total_borrowers
    FROM borrowing_records
    WHERE return_date IS NULL
    GROUP BY book_id
) AS books_count
ON LB.book_id = books_count.book_id
WHERE LB.total_copies = books_count.total_borrowers
ORDER BY current_borrowers DESC, LB.title ASC