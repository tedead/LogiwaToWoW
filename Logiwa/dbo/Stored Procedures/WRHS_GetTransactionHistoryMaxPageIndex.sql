CREATE PROCEDURE [dbo].[WRHS_GetTransactionHistoryMaxPageIndex]
AS
BEGIN
	SELECT SelectedPageIndex, CAST(FORMAT(CAST(DATEADD(MONTH, DATEDIFF(MONTH, 0, TransactionStartDate), 0) AS DATE), 'MM.dd.yyyy') as VARCHAR(10)) + ' 00:00:00' AS StartDate
	FROM TransactionHistory
	WHERE TransactionHistoryID = (SELECT MAX(TransactionHistoryID) FROM TransactionHistory)
END