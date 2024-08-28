/* Write your T-SQL query statement below */

SELECT 
    st.student_id, 
    st.student_name,
    su.subject_name,
    COUNT(e.subject_name) as attended_exams 
FROM 
    Students st
CROSS JOIN 
    Subjects su
LEFT JOIN 
    Examinations e ON e.student_id = st.student_id AND e.subject_name = su.subject_name
GROUP BY 
    st.student_id, 
    st.student_name,
    su.subject_name
ORDER BY 
    st.student_id, 
    su.subject_name