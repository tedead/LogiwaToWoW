﻿CREATE PROCEDURE WRHS_insTransactionHistory(
	@ID INT,
    @User VARCHAR(1000),
    @InventoryItemID INT,
    @InventoryItemCode VARCHAR(1000),
    @InventoryItemDescription VARCHAR(1000),
    @Barcode VARCHAR(1000),
    @InventorySiteID INT,
    @InventorySiteDescription VARCHAR(1000),
    @TransactionTypeID INT,
    @TransactionTypeDescription VARCHAR(1000),
    @TransactionSubTypeID INT,
    @TransactionSubTypeDescription VARCHAR(1000),
    @LocationID INT,
    @LocationDescription VARCHAR(1000),
    @WarehouseID INT,
    @WarehouseDescription VARCHAR(1000),
    @DepositorID INT,
    @DepositorDescription VARCHAR(1000),
    @WarehouseReceiptID INT,
    @WarehouseReceiptDescription VARCHAR(1000),
    @ReceiptID INT,
    @ReceiptDescription VARCHAR(1000),
    @EntryDateTime VARCHAR(1000),
    @EntryDateTime_Start VARCHAR(1000),
    @EntryDateTime_End VARCHAR(1000),
    @TransactionStartDate VARCHAR(1000),
    @TransactionStartDate_Start VARCHAR(1000),
    @TransactionStartDate_End VARCHAR(1000),
    @TransactionFinishDate VARCHAR(1000),
    @TransactionFinishDate_Start VARCHAR(1000),
    @TransactionFinishDate_End VARCHAR(1000),
    @Host VARCHAR(1000),
    @Session VARCHAR(1000),
    @ProductionOrderID INT,
    @ProductionOrderDescription VARCHAR(1000),
    @ReceiptItemID INT,
    @ShipmentID INT,
    @ShipmentDescription VARCHAR(1000),
    @ShipmentItemID INT,
    @WarehouseOrderID INT,
    @WarehouseOrderDescription VARCHAR(1000),
    @WarehouseOrderDetailID INT,
    @WarehouseReceiptDetailID INT,
    @ProductionOrderDetailID INT,
    @ProductionOrderDetailDescription VARCHAR(1000),
    @CountPlanRevisionID INT,
    @CountPlanRevisionDescription VARCHAR(1000),
    @Canceled BIT,
    @CuInventoryItemPackTypeID INT,
    @CuInventoryItemPackTypeDescription VARCHAR(1000),
    @InventoryItemPackTypeID INT,
    @InventoryItemPackTypeDescription VARCHAR(1000),
    @LotBatchNo VARCHAR(1000),
    @ProductionDate VARCHAR(1000),
    @ProductionDate_Start VARCHAR(1000),
    @ProductionDate_End VARCHAR(1000),
    @ExpireDate VARCHAR(1000),
    @ExpireDate_Start VARCHAR(1000),
    @ExpireDate_End VARCHAR(1000),
    @ReferanceNo VARCHAR(1000),
    @StockKitCode VARCHAR(1000),
    @StockId VARCHAR(1000),
    @ProjectID INT,
    @ProjectDescription VARCHAR(1000),
    @CustomerID INT,
    @CustomerDescription VARCHAR(1000),
    @TransactionHistPalletID INT,
    @TransactionHistPalletDescription VARCHAR(1000),
    @Quantity NUMERIC(19, 5),
    @WarehouseReceiptSupplierID INT,
    @WarehouseReceiptSupplierCode VARCHAR(1000),
    @OrderCustomerID INT,
    @OrderCustomerCode VARCHAR(1000),
    @QuarantineResaonID INT,
    @QuarantineResaonDescription VARCHAR(1000),
    @SuitabilityReasonID INT,
    @SuitabilityReasonDescription VARCHAR(1000),
    @FreeAttr1 VARCHAR(1000),
    @FreeAttr2 VARCHAR(1000),
    @FreeAttr3 VARCHAR(1000),
    @PackedQuantity NUMERIC(19, 5),
    @LocationDisplayMember VARCHAR(1000),
    @HistoryId VARCHAR(1000),
    @WarehouseOrderType VARCHAR(1000),
    @WarehouseOrderTypeCode VARCHAR(1000),
    @WarehouseOrderTypeID INT,
    @PageSize INT,
    @SelectedPageIndex INT,
    @PageCount INT,
    @RecordCount INT
)
AS
BEGIN
	INSERT INTO TransactionHistory(
	ID,
    [User] ,
    InventoryItemID ,
    InventoryItemCode ,
    InventoryItemDescription ,
    Barcode ,
    InventorySiteID ,
    InventorySiteDescription ,
    TransactionTypeID ,
    TransactionTypeDescription ,
    TransactionSubTypeID ,
    TransactionSubTypeDescription ,
    LocationID ,
    LocationDescription ,
    WarehouseID ,
    WarehouseDescription ,
    DepositorID ,
    DepositorDescription ,
    WarehouseReceiptID ,
    WarehouseReceiptDescription ,
    ReceiptID ,
    ReceiptDescription ,
    EntryDateTime ,
    EntryDateTime_Start ,
    EntryDateTime_End ,
    TransactionStartDate ,
    TransactionStartDate_Start ,
    TransactionStartDate_End ,
    TransactionFinishDate ,
    TransactionFinishDate_Start ,
    TransactionFinishDate_End ,
    Host ,
    [Session] ,
    ProductionOrderID ,
    ProductionOrderDescription ,
    ReceiptItemID ,
    ShipmentID ,
    ShipmentDescription ,
    ShipmentItemID ,
    WarehouseOrderID ,
    WarehouseOrderDescription ,
    WarehouseOrderDetailID ,
    WarehouseReceiptDetailID ,
    ProductionOrderDetailID ,
    ProductionOrderDetailDescription ,
    CountPlanRevisionID ,
    CountPlanRevisionDescription ,
    Canceled,
    CuInventoryItemPackTypeID ,
    CuInventoryItemPackTypeDescription ,
    InventoryItemPackTypeID ,
    InventoryItemPackTypeDescription ,
    LotBatchNo ,
    ProductionDate ,
    ProductionDate_Start ,
    ProductionDate_End ,
    [ExpireDate],
    ExpireDate_Start ,
    ExpireDate_End ,
    ReferanceNo ,
    StockKitCode ,
    StockId ,
    ProjectID ,
    ProjectDescription ,
    CustomerID ,
    CustomerDescription ,
    TransactionHistPalletID ,
    TransactionHistPalletDescription ,
    Quantity ,
    WarehouseReceiptSupplierID ,
    WarehouseReceiptSupplierCode ,
    OrderCustomerID ,
    OrderCustomerCode ,
    QuarantineResaonID ,
    QuarantineResaonDescription ,
    SuitabilityReasonID ,
    SuitabilityReasonDescription ,
    FreeAttr1 ,
    FreeAttr2 ,
    FreeAttr3 ,
    PackedQuantity ,
    LocationDisplayMember ,
    HistoryId ,
    WarehouseOrderType ,
    WarehouseOrderTypeCode ,
    WarehouseOrderTypeID ,
    PageSize ,
    SelectedPageIndex ,
    [PageCount] ,
    RecordCount
	)

SELECT 	
@ID ,
    @User ,
    @InventoryItemID ,
    @InventoryItemCode ,
    @InventoryItemDescription ,
    @Barcode ,
    @InventorySiteID ,
    @InventorySiteDescription ,
    @TransactionTypeID ,
    @TransactionTypeDescription ,
    @TransactionSubTypeID ,
    @TransactionSubTypeDescription ,
    @LocationID ,
    @LocationDescription ,
    @WarehouseID ,
    @WarehouseDescription ,
    @DepositorID ,
    @DepositorDescription ,
    @WarehouseReceiptID ,
    @WarehouseReceiptDescription ,
    @ReceiptID ,
    @ReceiptDescription ,
    @EntryDateTime ,
    @EntryDateTime_Start ,
    @EntryDateTime_End ,
    @TransactionStartDate ,
    @TransactionStartDate_Start ,
    @TransactionStartDate_End ,
    @TransactionFinishDate ,
    @TransactionFinishDate_Start ,
    @TransactionFinishDate_End ,
    @Host ,
    @Session ,
    @ProductionOrderID ,
    @ProductionOrderDescription ,
    @ReceiptItemID ,
    @ShipmentID ,
    @ShipmentDescription ,
    @ShipmentItemID ,
    @WarehouseOrderID ,
    @WarehouseOrderDescription ,
    @WarehouseOrderDetailID ,
    @WarehouseReceiptDetailID ,
    @ProductionOrderDetailID ,
    @ProductionOrderDetailDescription ,
    @CountPlanRevisionID ,
    @CountPlanRevisionDescription ,
    @Canceled,
    @CuInventoryItemPackTypeID ,
    @CuInventoryItemPackTypeDescription ,
    @InventoryItemPackTypeID ,
    @InventoryItemPackTypeDescription ,
    @LotBatchNo ,
    @ProductionDate ,
    @ProductionDate_Start ,
    @ProductionDate_End ,
    @ExpireDate ,
    @ExpireDate_Start ,
    @ExpireDate_End ,
    @ReferanceNo ,
    @StockKitCode ,
    @StockId ,
    @ProjectID ,
    @ProjectDescription ,
    @CustomerID ,
    @CustomerDescription ,
    @TransactionHistPalletID ,
    @TransactionHistPalletDescription ,
    @Quantity ,
    @WarehouseReceiptSupplierID ,
    @WarehouseReceiptSupplierCode ,
    @OrderCustomerID ,
    @OrderCustomerCode ,
    @QuarantineResaonID ,
    @QuarantineResaonDescription ,
    @SuitabilityReasonID ,
    @SuitabilityReasonDescription ,
    @FreeAttr1 ,
    @FreeAttr2 ,
    @FreeAttr3 ,
    @PackedQuantity ,
    @LocationDisplayMember ,
    @HistoryId ,
    @WarehouseOrderType ,
    @WarehouseOrderTypeCode ,
    @WarehouseOrderTypeID ,
    @PageSize ,
    @SelectedPageIndex ,
    @PageCount ,
    @RecordCount 
END