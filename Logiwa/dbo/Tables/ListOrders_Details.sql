﻿CREATE TABLE [dbo].[ListOrders_Details] (
    [DetailsID]                        INT             IDENTITY (1, 1) NOT NULL,
    [ID]                               INT             NULL,
    [Code]                             VARCHAR (1000)  NULL,
    [InventoryItemID]                  INT             NULL,
    [InventoryItemDescription]         VARCHAR (1000)  NULL,
    [InventoryItemInfo]                VARCHAR (1000)  NULL,
    [Barcode]                          VARCHAR (1000)  NULL,
    [DisplayMember]                    VARCHAR (1000)  NULL,
    [InventoryItemPackTypeID]          INT             NULL,
    [InventoryItemPackTypeDescription] VARCHAR (1000)  NULL,
    [PackQuantity]                     NUMERIC (19, 5) NULL,
    [WarehouseOrderID]                 INT             NULL,
    [UnitWeight]                       NUMERIC (19, 5) NULL,
    [UnitVolume]                       NUMERIC (19, 5) NULL,
    [PACKIIPT_UnitWeight]              NUMERIC (19, 5) NULL,
    [AllocatedCuQuantity]              NUMERIC (19, 5) NULL,
    [PickedCuQuantity]                 NUMERIC (19, 5) NULL,
    [LoadedCuQuantity]                 NUMERIC (19, 5) NULL,
    [ShippedCuQuantity]                NUMERIC (19, 5) NULL,
    [PlannedPackQuantity]              NUMERIC (19, 5) NULL,
    [PlannedCuQuantity]                NUMERIC (19, 5) NULL,
    [SortedCUQuantity]                 NUMERIC (19, 5) NULL,
    [PackedCUQuantity]                 NUMERIC (19, 5) NULL,
    [CancelledCuQuantity]              NUMERIC (19, 5) NULL,
    [FreeAttr1]                        VARCHAR (1000)  NULL,
    [FreeAttr2]                        VARCHAR (1000)  NULL,
    [FreeAttr3]                        VARCHAR (1000)  NULL,
    [CurrencyPrice]                    NUMERIC (19, 5) NULL,
    [TaxRate]                          NUMERIC (19, 5) NULL,
    [NetCurrencyPrice]                 NUMERIC (19, 5) NULL,
    [TotalWeight]                      NUMERIC (19, 5) NULL,
    [TotalVolume]                      NUMERIC (19, 5) NULL,
    [LineWeight]                       NUMERIC (19, 5) NULL,
    [SupplierID]                       NUMERIC (19, 5) NULL,
    [SupplierDescription]              VARCHAR (1000)  NULL,
    [Notes1]                           VARCHAR (1000)  NULL,
    [SalesUnitPrice]                   NUMERIC (19, 5) NULL,
    [ChannelOrderDetailCode]           VARCHAR (1000)  NULL,
    [Errors]                           VARCHAR (1000)  NULL,
    [Success]                          BIT             NULL,
    [SuccessMessage]                   VARCHAR (1000)  NULL,
    [IsExcelExport]                    BIT             NULL,
    [PageSize]                         INT             NULL,
    [SelectedPageIndex]                INT             NULL,
    [PageCount]                        INT             NULL,
    [RecordCount]                      INT             NULL,
    PRIMARY KEY CLUSTERED ([DetailsID] ASC)
);

