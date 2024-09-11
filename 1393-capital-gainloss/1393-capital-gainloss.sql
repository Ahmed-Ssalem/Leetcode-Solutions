/* Write your T-SQL query statement below */

WITH Total_Buy_Sell AS
(
    SELECT 
        stock_name,
        operation,
        SUM(price) AS gain_loss
    FROM Stocks
    GROUP BY 
        stock_name, 
        operation
)

SELECT 
    T1.stock_name,
    SUM(T1.gain_loss - T2.gain_loss) AS capital_gain_loss
FROM Total_Buy_Sell T1
JOIN Total_Buy_Sell T2 
ON 
    T1.stock_name = T2.stock_name AND 
    T1.operation <> T2.operation AND 
    T1.operation = 'Sell'
GROUP BY T1.stock_name