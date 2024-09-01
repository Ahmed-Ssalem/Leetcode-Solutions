/* Write your T-SQL query statement below */

SELECT *
FROM Patients
WHERE conditions LIKE '%DIAB1%'
ORDER BY patient_id;
