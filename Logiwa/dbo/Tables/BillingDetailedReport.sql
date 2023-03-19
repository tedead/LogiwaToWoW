CREATE TABLE [dbo].[BillingDetailedReport] (
    [BillingDetailedReportID]              INT             IDENTITY (1, 1) NOT NULL,
    [ID]                                   INT             NULL,
    [WarehouseID]                          INT             NULL,
    [WarehouseDescription]                 VARCHAR (500)   NULL,
    [DepositorID]                          INT             NULL,
    [DepositorDescription]                 VARCHAR (500)   NULL,
    [WarehouseContractID]                  INT             NULL,
    [WarehouseContractDescription]         VARCHAR (500)   NULL,
    [WarehouseContractLineID]              INT             NULL,
    [WarehouseContractLineDescription]     VARCHAR (500)   NULL,
    [WarehouseContractPeriodsID]           VARCHAR (MAX)   NULL,
    [WarehouseContractPeriodID]            INT             NULL,
    [WarehouseContractPeriodDescription]   VARCHAR (500)   NULL,
    [ActivityDate]                         VARCHAR (500)   NULL,
    [ActivityDate_Start]                   VARCHAR (500)   NULL,
    [ActivityDate_End]                     VARCHAR (500)   NULL,
    [CalculatedMetricUnit]                 NUMERIC (19, 5) NULL,
    [CalculatedTotalPrice]                 NUMERIC (19, 5) NULL,
    [ObjectType]                           VARCHAR (500)   NULL,
    [ObjectID]                             VARCHAR (500)   NULL,
    [PartyReferance]                       VARCHAR (500)   NULL,
    [PartyReference]                       VARCHAR (500)   NULL,
    [CalculationInfo]                      VARCHAR (MAX)   NULL,
    [Notes]                                VARCHAR (MAX)   NULL,
    [IsBilled]                             BIT             NULL,
    [IsInvoiceable]                        BIT             NULL,
    [IsError]                              BIT             NULL,
    [StartQuantity]                        NUMERIC (19, 5) NULL,
    [FinishQuantity]                       NUMERIC (19, 5) NULL,
    [Price]                                NUMERIC (19, 5) NULL,
    [WarehouseContractLinePricingTypeID]   INT             NULL,
    [WarehouseContractLinePricingTypeCode] VARCHAR (500)   NULL,
    [WarehouseContractLineReference]       VARCHAR (500)   NULL,
    [PageSize]                             INT             NULL,
    [SelectedPageIndex]                    INT             NULL,
    [PageCount]                            INT             NULL,
    [RecordCount]                          INT             NULL,
    CONSTRAINT [PK__BillingD__EF28502EF8036436] PRIMARY KEY CLUSTERED ([BillingDetailedReportID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_BillingDetailedReport_ID_WarehouseContractDescription_WarehouseContractPeriodDescription]
    ON [dbo].[BillingDetailedReport]([ID] ASC, [WarehouseContractDescription] ASC, [WarehouseContractPeriodDescription] ASC);

