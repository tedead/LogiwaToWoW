﻿CREATE PROCEDURE [dbo].[WRHS_insBillingDetailedReport](
	@ID INT,
	@WarehouseID INT,
	@WarehouseDescription VARCHAR(500),
	@DepositorID INT,
	@DepositorDescription VARCHAR(500),
	@WarehouseContractID INT,
	@WarehouseContractDescription VARCHAR(500),
	@WarehouseContractLineID INT,
	@WarehouseContractLineDescription VARCHAR(500),
	@WarehouseContractPeriodsID VARCHAR(MAX),
	@WarehouseContractPeriodID INT,
	@WarehouseContractPeriodDescription VARCHAR(500),
	@ActivityDate VARCHAR(500),
	@ActivityDate_Start VARCHAR(500),
	@ActivityDate_End VARCHAR(500),
	@CalculatedMetricUnit NUMERIC(19, 5),
	@CalculatedTotalPrice NUMERIC(19, 5),
	@ObjectType VARCHAR(500),
	@ObjectID VARCHAR(500),
	@PartyReferance VARCHAR(500),
	@PartyReference VARCHAR(500),
	@CalculationInfo VARCHAR(MAX),
	@Notes VARCHAR(MAX),
	@IsBilled BIT,
	@IsInvoiceable BIT,
	@IsError BIT,
	@StartQuantity NUMERIC(19, 5),
	@FinishQuantity NUMERIC(19, 5),
	@Price NUMERIC(19, 5),
	@WarehouseContractLinePricingTypeID INT,
	@WarehouseContractLinePricingTypeCode VARCHAR(500),
	@WarehouseContractLineReference VARCHAR(500),
	@PageSize INT,
	@SelectedPageIndex INT,
	@PageCount INT,
	@RecordCount INT
)
AS
BEGIN
--IF NOT EXISTS(SELECT 1 
--			  FROM BillingDetailedReport 
--			  WHERE ID = @ID
--				    AND WarehouseContractDescription = @WarehouseContractDescription
--				    AND WarehouseContractPeriodDescription = @WarehouseContractPeriodDescription
--			 )
--BEGIN
	INSERT INTO BillingDetailedReport
	SELECT @ID,
	@WarehouseID,
	@WarehouseDescription,
	@DepositorID,
	@DepositorDescription,
	@WarehouseContractID,
	@WarehouseContractDescription,
	@WarehouseContractLineID,
	@WarehouseContractLineDescription,
	@WarehouseContractPeriodsID,
	@WarehouseContractPeriodID,
	@WarehouseContractPeriodDescription,
	@ActivityDate,
	@ActivityDate_Start,
	@ActivityDate_End,
	@CalculatedMetricUnit,
	@CalculatedTotalPrice,
	@ObjectType,
	@ObjectID,
	@PartyReferance,
	@PartyReference,
	@CalculationInfo,
	@Notes,
	@IsBilled,
	@IsInvoiceable,
	@IsError,
	@StartQuantity,
	@FinishQuantity,
	@Price,
	@WarehouseContractLinePricingTypeID,
	@WarehouseContractLinePricingTypeCode,
	@WarehouseContractLineReference,
	@PageSize,
	@SelectedPageIndex,
	@PageCount,
	@RecordCount
END
--END