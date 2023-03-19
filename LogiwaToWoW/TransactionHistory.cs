using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiwaToWoW
{
    class TransactionHistory
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Datum
        {
            public int ID { get; set; }
            public string User { get; set; }
            public int InventoryItemID { get; set; }
            public string InventoryItemCode { get; set; }
            public string InventoryItemDescription { get; set; }
            public string Barcode { get; set; }
            public int InventorySiteID { get; set; }
            public string InventorySiteDescription { get; set; }
            public int TransactionTypeID { get; set; }
            public string TransactionTypeDescription { get; set; }
            public int TransactionSubTypeID { get; set; }
            public string TransactionSubTypeDescription { get; set; }
            public int LocationID { get; set; }
            public string LocationDescription { get; set; }
            public int WarehouseID { get; set; }
            public string WarehouseDescription { get; set; }
            public int DepositorID { get; set; }
            public string DepositorDescription { get; set; }
            public int WarehouseReceiptID { get; set; }
            public string WarehouseReceiptDescription { get; set; }
            public int ReceiptID { get; set; }
            public string ReceiptDescription { get; set; }
            public string EntryDateTime { get; set; }
            public string EntryDateTime_Start { get; set; }
            public string EntryDateTime_End { get; set; }
            public string TransactionStartDate { get; set; }
            public string TransactionStartDate_Start { get; set; }
            public string TransactionStartDate_End { get; set; }
            public string TransactionFinishDate { get; set; }
            public string TransactionFinishDate_Start { get; set; }
            public string TransactionFinishDate_End { get; set; }
            public string Host { get; set; }
            public string Session { get; set; }
            public int ProductionOrderID { get; set; }
            public string ProductionOrderDescription { get; set; }
            public int ReceiptItemID { get; set; }
            public int ShipmentID { get; set; }
            public string ShipmentDescription { get; set; }
            public int ShipmentItemID { get; set; }
            public int WarehouseOrderID { get; set; }
            public string WarehouseOrderDescription { get; set; }
            public int WarehouseOrderDetailID { get; set; }
            public int WarehouseReceiptDetailID { get; set; }
            public int ProductionOrderDetailID { get; set; }
            public string ProductionOrderDetailDescription { get; set; }
            public int CountPlanRevisionID { get; set; }
            public string CountPlanRevisionDescription { get; set; }
            public string Canceled { get; set; }
            public int CuInventoryItemPackTypeID { get; set; }
            public string CuInventoryItemPackTypeDescription { get; set; }
            public int InventoryItemPackTypeID { get; set; }
            public string InventoryItemPackTypeDescription { get; set; }
            public string LotBatchNo { get; set; }
            public string ProductionDate { get; set; }
            public string ProductionDate_Start { get; set; }
            public string ProductionDate_End { get; set; }
            public string ExpireDate { get; set; }
            public string ExpireDate_Start { get; set; }
            public string ExpireDate_End { get; set; }
            public string ReferanceNo { get; set; }
            public string StockKitCode { get; set; }
            public string StockId { get; set; }
            public int ProjectID { get; set; }
            public string ProjectDescription { get; set; }
            public int CustomerID { get; set; }
            public string CustomerDescription { get; set; }
            public int TransactionHistPalletID { get; set; }
            public string TransactionHistPalletDescription { get; set; }
            public int Quantity { get; set; }
            public int WarehouseReceiptSupplierID { get; set; }
            public string WarehouseReceiptSupplierCode { get; set; }
            public int OrderCustomerID { get; set; }
            public string OrderCustomerCode { get; set; }
            public int QuarantineResaonID { get; set; }
            public string QuarantineResaonDescription { get; set; }
            public int SuitabilityReasonID { get; set; }
            public string SuitabilityReasonDescription { get; set; }
            public string FreeAttr1 { get; set; }
            public string FreeAttr2 { get; set; }
            public string FreeAttr3 { get; set; }
            public string PackedQuantity { get; set; }
            public string LocationDisplayMember { get; set; }
            public string HistoryId { get; set; }
            public string WarehouseOrderType { get; set; }
            public string WarehouseOrderTypeCode { get; set; }
            public string WarehouseOrderTypeID { get; set; }
            public int PageSize { get; set; }
            public int SelectedPageIndex { get; set; }
            public int PageCount { get; set; }
            public int RecordCount { get; set; }
        }

        public class LAClassInfo
        {
            public string ClassName { get; set; }
            public string PrimaryKey { get; set; }
            public string TypeId { get; set; }
        }

        public class Root
        {
            public string QueryTimeStamp_Start { get; set; }
            public string QueryTimeStamp_End { get; set; }
            public LAClassInfo LAClassInfo { get; set; }
            public List<Datum> Data { get; set; }
            public List<object> Errors { get; set; }
            public List<object> Columns { get; set; }
            public bool Success { get; set; }
            public string SuccessMessage { get; set; }
            public string LAClassName { get; set; }
            public DateTime EventPlannedFinishDateTime { get; set; }
            public string EventAssessment { get; set; }
            public int EventuserId { get; set; }
        }


    }
}
